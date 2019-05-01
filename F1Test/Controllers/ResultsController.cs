using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using F1Test.Services;
using F1Test.ViewModels;

namespace F1Test.Controllers
{
    public class ResultsController : Controller
    {
        private ResultService _resultService = new ResultService();

        // GET: Results
        public ActionResult Index(int id, int round)
        {
            var resultsArray = _resultService.GetResultsForRound(id, round);
            var result = new ScheduledRaces
            {
                Races = resultsArray,
                Round = round,
                Year = id
            };

            return View(result);
        }
    }
}