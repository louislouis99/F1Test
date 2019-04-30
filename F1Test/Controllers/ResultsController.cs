using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using F1Test.Services;

namespace F1Test.Controllers
{
    public class ResultsController : Controller
    {
        private ResultService _resultService = new ResultService();

        // GET: Results
        public ActionResult Index(int id)
        {

            return View();
        }
    }
}