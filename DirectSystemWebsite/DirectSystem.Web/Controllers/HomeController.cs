using DirectSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DirectSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           
            return View();
        }
        [HttpGet]
        public ActionResult CreateData()
        {
            ViewBag.Message = "Your app description page.";
            var newInitModel = new EntryDataInitModel
            {
                InitDateTime=DateTime.Now,
                IsPromotion=false
            };
            return View(newInitModel);
        }
        [HttpPost]
        public ActionResult InitCreateData()
        {

            return View();
        }
        [HttpGet]
        public ActionResult CreateQuery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public HomeController()
        {
            timeToStart = int.Parse(System.Configuration.ConfigurationManager.AppSettings["TimeToStart"]);
            timeToEnd = int.Parse(System.Configuration.ConfigurationManager.AppSettings["TimeToEnd"]);
        }

        private List<SessionModel> CreateSessionList(int startTime, int endTime)
        {
            var result = new List<SessionModel>();
            for (int i = startTime; i < endTime; i++)
            {
                var newSession = new SessionModel
                {
                    Index=i,
                    StartTime = i,
                    EndTime = i++
                };
                result.Add(newSession);
            }

            return result;

        }
        private readonly int timeToStart = 0;
        private readonly int timeToEnd = 0;
    }
}
