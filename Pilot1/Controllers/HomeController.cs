using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Tinder4Jobs.Model;
using Tinder4Jobs.Services;
using Tinder4Jobs.Web.ViewModels;
using Tinder4Jobs.Data.Repository;
using Tinder4Jobs.Data.Infrastructure;
using Tinder4Jobs.DTO;

namespace Tinder4Jobs.Web.Controllers
{
    public class HomeController : Controller
    {

        LinkedinJobListDTO joblist = null;
        private readonly ILinkedinService linkedinService;

        public HomeController(ILinkedinService linkedinService)
        {
            this.linkedinService = linkedinService;
        }

        public ActionResult Index()
        {
            // Test
            var users = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().Users.Where(u => u.LinkedinToken != null).ToList();

            //var users = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().Users.ToList();


            if (users != null && users.Count > 0)
            {
                linkedinService.AccessToken = users[0].LinkedinToken;

                joblist = linkedinService.GetJobSuggestions();

                Session["jobList"] = joblist;

                var jobModelList = AutoMapper.Mapper.Map<List<LinkedinJobDTO>, List<LinkedinJob>>(joblist.Jobs.Values.ToList());

                // save to database
                foreach (var job in jobModelList)
                {
                    //linkedinService.AddJob(job);
                    linkedinService.SaveJob(job);
                }


                // Convert to viewmodel
                var jobViewModelList = AutoMapper.Mapper.Map<List<LinkedinJob>, List<LinkedinJobViewModel>>(jobModelList);

                return View(jobViewModelList);
            }
            else

                return RedirectToAction("Login", "Account");
        }


        public ActionResult JobDetail(string jobId)
        {
            // Mockado

            joblist = (LinkedinJobListDTO)Session["jobList"];

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