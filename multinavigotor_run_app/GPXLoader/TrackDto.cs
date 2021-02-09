using System;
using Geolocation;

namespace multinavigotor_run_app
{
    public class TrackDto
    {
        public int Id { get; set; }
        public Coordinate Coordinate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Elevation { get; set; }
        public DateTime Time { get; set; }
        public double Distance { get; set; }
    }
}
