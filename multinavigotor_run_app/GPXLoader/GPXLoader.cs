using multinavigotor_run_app.GPXLoader;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace multinavigotor_run_app.GPXLoader
{
    public class GPXLoader
    {
        /// <summary>
        /// Load the Xml document for parsing
        /// </summary>
        /// <param name="sFile">Fully qualified file name (local)</param>
        /// <returns>XDocument</returns>
        private XDocument GetGpxDoc(string sFile)
        {
            XDocument gpxDoc = XDocument.Load(sFile);
            return gpxDoc;
        }

        /// <summary>
        /// Load the namespace for a standard GPX document
        /// </summary>
        /// <returns></returns>
        private XNamespace GetGpxNameSpace()
        {
            XNamespace gpx = XNamespace.Get("http://www.topografix.com/GPX/1/1");
            return gpx;
        }

        /// <summary>
        /// When passed a file, open it and parse all waypoints from it.
        /// </summary>
        /// <param name="sFile">Fully qualified file name (local)</param>
        /// <returns>string containing line delimited waypoints from
        /// the file (for test)</returns>
        /// <remarks>Normally, this would be used to populate the
        /// appropriate object model</remarks>
        public string LoadGPXWaypoints(string sFile)
        {
            XDocument gpxDoc = GetGpxDoc(sFile);
            XNamespace gpx = GetGpxNameSpace();

            var waypoints = from waypoint in gpxDoc.Descendants(gpx + "wpt")
                            select new
                            {
                                Latitude = waypoint.Attribute("lat").Value,
                                Longitude = waypoint.Attribute("lon").Value,
                                Elevation = waypoint.Element(gpx + "ele") != null ?
                                  waypoint.Element(gpx + "ele").Value : null,
                                Name = waypoint.Element(gpx + "name") != null ?
                                  waypoint.Element(gpx + "name").Value : null,
                                Dt = waypoint.Element(gpx + "cmt") != null ?
                                  waypoint.Element(gpx + "cmt").Value : null
                            };

            StringBuilder sb = new StringBuilder();
            foreach (var wpt in waypoints)
            {
                // This is where we'd instantiate data
                // containers for the information retrieved.
                sb.Append(
                  string.Format("Name:{0} Latitude:{1} Longitude:{2} Elevation:{3} Date:{4}\n",
                  wpt.Name, wpt.Latitude, wpt.Longitude,
                  wpt.Elevation, wpt.Dt));
            }

            return sb.ToString();
        }

        //public static List<TrackDto> tracksAsList = new List<TrackDto>();

        /// <summary>
        /// When passed a file, open it and parse all tracks
        /// and track segments from it.
        /// </summary>
        /// <param name="sFile">Fully qualified file name (local)</param>
        /// <returns>string containing line delimited waypoints from the
        /// file (for test)</returns>
        public string LoadGPXTracks(string sFile)
        {
            XDocument gpxDoc = GetGpxDoc(sFile);
            XNamespace gpx = GetGpxNameSpace();
            var tracks = from track in gpxDoc.Descendants(gpx + "trk")
                         select new
                         {
                             Name = track.Element(gpx + "name") != null ?
                            track.Element(gpx + "name").Value : null,
                             Segs = (
                                from trackpoint in track.Descendants(gpx + "trkpt")
                                select new
                                {
                                    Latitude = trackpoint.Attribute("lat").Value,
                                    Longitude = trackpoint.Attribute("lon").Value,
                                    Elevation = trackpoint.Element(gpx + "ele") != null ? trackpoint.Element(gpx + "ele").Value : null,
                                    Time = trackpoint.Element(gpx + "time") != null ? trackpoint.Element(gpx + "time").Value : null
                                }
                              )
                         };

            StringBuilder sb = new StringBuilder();
            List<TrackDto> tracksAsList = new List<TrackDto>();

            foreach (var trk in tracks)
            {
                // Populate track data objects.
                foreach (var trkSeg in trk.Segs)
                {
                    // Populate detailed track segments
                    // in the object model here.
                    TrackDto trackDto = new TrackDto
                    {
                        Latitude = double.Parse(trkSeg.Latitude, System.Globalization.CultureInfo.InvariantCulture),
                        Longitude = double.Parse(trkSeg.Longitude, System.Globalization.CultureInfo.InvariantCulture),
                        Elevation = double.Parse(trkSeg.Elevation, System.Globalization.CultureInfo.InvariantCulture),
                        Time = convertIsoToDateTime(trkSeg.Time)
                    };

                    tracksAsList.Add(trackDto);
                    sb.Append(
                      string.Format("Track:{0} - Latitude:{1} Longitude:{2} " + "Elevation:{3} Date:{4}\n",
                        trk.Name, trkSeg.Latitude, trkSeg.Longitude, trkSeg.Elevation, trkSeg.Time));
                }
            }

            string _runnerName = getNameFromFileName(Path.GetFileName(sFile));
            TimeSpan _duration = tracksAsList.Last().Time - tracksAsList.First().Time;

            Runner runner = new Runner
            {
                Name = _runnerName,
                DateofRunning = tracksAsList.First().Time.Date,
                RunTime = Convert.ToDateTime(_duration.ToString()),
                Elevation = CountEleDif(tracksAsList)
            };

            Console.WriteLine("Dif Ele: {0}", CountEleDif(tracksAsList));
            Console.WriteLine("Max Ele: {0} - Min Ele: {1}", FindMaxEle(tracksAsList), FindMinEle(tracksAsList));
            Console.WriteLine("Name: {0}, Duration: {1}", _runnerName, tracksAsList.Last().Time - tracksAsList.First().Time);
            Console.WriteLine("Name: {0}, Duration: {1}", _runnerName, _duration);
            Console.WriteLine("tracksAsList.First().Time.Day: " + tracksAsList.First().Time.Date);

            return sb.ToString();
            //return trackAsList; // Return as List
        }

        /// <summary>
        /// It is a string to DateTime converter (yyyy-MM-dd'T'HH:mm:ss'Z')
        /// </summary>
        /// <param name="iso"></param>
        /// <returns>DateTime (yyyy-MM-dd'T'HH:mm:ss'Z') </returns>
        public DateTime convertIsoToDateTime(string iso)
        {
            return DateTime.ParseExact(iso, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// split the file name to get the runner name Example for a file name: Daniel_Smith_2020-08-15_13-08-53.GPX
        /// </summary>
        /// <param name="_fileName"></param>
        /// <returns>The name of the runner</returns>
        public string getNameFromFileName(string _fileName)
        {
            string[] _split = _fileName.Split('_');
            string runnerName = null;

            for (int i = 0; i < 2; i++)
            {
                runnerName += _split[i];
                if (i == 0)
                {
                    runnerName += " ";
                }
            }
            return runnerName;
        }

        /// <summary>
        /// It find the max elevation in the list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public double CountEleDif(List<TrackDto> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            double maxEle = double.MinValue;
            double minEle = 333.0;
            double difEle = maxEle - minEle;
            foreach (TrackDto type in list)
            {
                if (type.Elevation > maxEle)
                {
                    maxEle = type.Elevation;
                }
                if (type.Elevation < minEle)
                {
                    minEle = type.Elevation;
                }
            }
            return difEle;
        }

        public double FindMaxEle(List<TrackDto> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            double maxEle = double.MinValue;
            foreach (TrackDto type in list)
            {
                if (type.Elevation > maxEle)
                {
                    maxEle = type.Elevation;
                }
            }
            return maxEle;
        }

        public double FindMinEle(List<TrackDto> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            double minEle = 333.0;
            foreach (TrackDto type in list)
            {
                if (type.Elevation < minEle)
                {
                    minEle = type.Elevation;
                }
            }
            return minEle;
        }
    }
}
