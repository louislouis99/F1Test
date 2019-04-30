using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace F1Test.Services
{
    public class ScheduleService
    {
        public JObject GetSchedule(int year)
        {
            using (var client = new WebClient())
            {
                var result = client.DownloadString($"https://ergast.com/api/f1/{year}.json");
                return JObject.Parse(result);
            }            
        }

        public IEnumerable<int> GetRaceYears()
        {
            return Enumerable.Range(1950, DateTime.Now.Year);
        }
    }
}