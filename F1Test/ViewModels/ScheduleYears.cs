using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace F1Test.ViewModels
{
    public class ScheduledRaces
    {
        public JArray Races { get; set; }
        public int Decade { get; set; }
    }
}