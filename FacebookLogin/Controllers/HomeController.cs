using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace FacebookLogin.Controllers
{
    [RequireHttps][Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View();
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