using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Pilot1.Services;
using Pilot1.Models;

namespace Pilot1.Controllers
{
    public class HomeController : Controller
    {

        LinkedinJobList joblist = null;

        public ActionResult Index()
        {
            // Test
            var users = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().Users.Where(u => u.LinkedinToken != null).ToList();

            if (users != null && users.Count > 0)
            {

                joblist = new LinkedInService(users[0].LinkedinToken).GetJobSuggestions();
            }

            Session["jobList"] = joblist;

            return View(joblist.Jobs.Values.ToList());
        }


        public ActionResult JobDetail(string jobId)
        {
            // Mockado

            joblist = (LinkedinJobList)Session["jobList"];

            var job = joblist
                        .Jobs
                        .Values
                        .FirstOrDefault();
                        

            return PartialView("_JobDetailPartialView", job);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}