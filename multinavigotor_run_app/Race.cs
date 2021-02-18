using System;
using System.Collections.Generic;
using System.Text;

namespace multinavigotor_run_app
{

    
    class Race
    {
        public string RaceName { get; set; }
        public DateTime DateofRunning { get; set; }
        public List<Runner> Runners { get; set; }
    }
}
