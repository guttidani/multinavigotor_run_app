using System;
using System.Collections.Generic;
using System.Text;

namespace multinavigotor_run_app
{
    enum Gender
    {
        Man,
        Woman
    }
    class Runner
    {
        public String Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Distance { get; set; }
        public double ElevationUp { get; set; }
        public double ElevationDown { get; set; }
        public string RunTime { get; set; }
        public DateTime DateofRunning { get; set; }

        public List<Runner> RunnersList()
        {
            List<Runner> runnersList = new List<Runner>();

            return runnersList;
        }
    }
}
