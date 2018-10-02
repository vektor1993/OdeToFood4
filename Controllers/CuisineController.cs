using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.OdeToFood4.Controllers
{
    public class CuisineController : Controller
    {
        //[Authorize]
        public ActionResult Search(string name = "no Value")
        {
            throw new Exception("Something terrible just happened!");
            
            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectToRoute("Default", new { controller = "Home", action="About" });
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        }
    }
}