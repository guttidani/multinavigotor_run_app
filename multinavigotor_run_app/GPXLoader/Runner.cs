using System;
using System.Collections.Generic;
using System.Text;

namespace multinavigotor_run_app
{
    class Runner
    {
        public int Id { get; set; }
        public bool Gender { get; set; }
        public String Name { get; set; }
        public double Distance { get; set; }
        public double ElevationUp { get; set; }
        public double ElevationDown { get; set; }
        public string RunTime { get; set; }
        public DateTime DateofRunning { get; set; }

        private static int _id = 1;

        public Runner()
        {
            this.Id = _id;
            _id++;
        }

        public List<Runner> RunnersList()
        {
            List<Runner> runnersList = new List<Runner>();

            return runnersList;
        }
    }
}
