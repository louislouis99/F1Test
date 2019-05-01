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
        public JArray GetSchedule(int year)
        {
            using (var client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                var jsonResult = client.DownloadString($"https://ergast.com/api/f1/{year}.json");              
                var result = JObject.Parse(jsonResult);
                JArray resultList = (JArray)result["MRData"]["RaceTable"]["Races"];

                return resultList;
            }
        }

        // get a list of decades
        public IEnumerable<int> GetScheduleDecades()
        {
            var years = GetScheduleYears();
            var results = years.Where(c => c % 10 == 0);

            return results;
        }

        // get a list of years for a decade
        public IEnumerable<int> GetScheduleYears(int decade)
        {
            var results = GetScheduleYears()
                .Where(c => c >= decade && c <= decade + 9);

            return results;
        }

        // get all years of f1 
        public IEnumerable<int> GetScheduleYears()
        {
            var start = 1950;
            return Enumerable.Range(start, (DateTime.Now.Year - start) + 1);
        }
    }
}