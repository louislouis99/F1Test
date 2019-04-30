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
           
            var name = results[0]["raceName"].ToString();
            Assert.IsTrue(name == "Brazilian Grand Prix");
        }

        [TestMethod]
        public void TestGetYearsF1()
        {
            var service = new ScheduleService();
            var results = service.GetScheduleYears().ToList();

            Assert.IsTrue(results.Min() == 1950 && results.Max() == 2019);
        }

        [TestMethod]
        public void TestGetScheduleDecades()
        {
            var service = new ScheduleService();
            var results = service.GetScheduleDecades();

            Assert.IsTrue(results.First() == 1950);
        }

        [TestMethod]
        public void TestGetScheduledYearsByDecade()
        {
            var service = new ScheduleService();
            var results = service.GetScheduleYears(2010);

            Assert.IsTrue(results.Min() == 2010 && results.Max() == 2019);
        }
    }

    
}
