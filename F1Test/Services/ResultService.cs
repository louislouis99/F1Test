using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json.Linq;

namespace F1Test.Services
{
    public class ResultService
    {
        public JArray GetResultsForRound(int id, int round)
        {
            using (var client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                var jsonResult = client.DownloadString($"http://ergast.com/api/f1/{id}/{round}/results.json");
                var result = JObject.Parse(jsonResult);

                JArray resultList = (JArray)result["MRData"]["RaceTable"]["Races"];
                return resultList;
            }
        }
    }
}