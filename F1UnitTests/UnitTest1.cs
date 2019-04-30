using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using F1Test.Services;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace F1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetScheduleForYear()
        {
            var service = new ScheduleService();
            var results = service.GetSchedule(1994);

            var race = results["MRData"]["RaceTable"]["Races"][0]["raceName"].ToString();
            Assert.IsTrue(race == "Brazilian Grand Prix");
        }

        public void TestGetYearsF1()
        {
            var service = new ScheduleService();
            var results = service.GetRaceYears().ToList();

            Assert.IsTrue(results.Min() == 1950 && results.Max() == 2019);
        }
    }

    
}
