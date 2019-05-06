using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using F1Test.Services;
using Newtonsoft.Json.Linq;
using F1Test.ViewModels;

namespace F1Test.Controllers
{
    public class ScheduleController : Controller
    {
        private ScheduleService _scheduleService = new ScheduleService();

        // GET: Schedule
        public ActionResult Index()
        {
            var results = _scheduleService.GetScheduleDecades();

            return View(results);
        }

        public ActionResult Years(int id)
        {
            var results = _scheduleService.GetScheduleYears(id);

            return View(results);
        }

        // get the scheduled races for the year
        public ActionResult Races(int id)
        {
            var decade = (int)Math.Truncate((decimal)(id / 10)) * 10;
            var resultsArray = _scheduleService.GetSchedule(id);
            var results = new ScheduledRaces
            {
                Decade = decade,
                Races = resultsArray,
                Year = id
            };

            return View(results);
        }
    }
}