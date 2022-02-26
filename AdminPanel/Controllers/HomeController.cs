using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            if (Session["ID"] == null) { Response.Redirect("https://localhost:44371/RegisterForm.aspx"); }
            else { Response.Redirect("https://localhost:44371/Dashboard.aspx"); }
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