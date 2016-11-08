using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jidla.Web.Controllers
{
    public class MealPlannerController : Controller
    {
        // GET: MealPlanner
        public ActionResult Index()
        {
            return View();
        }
    }
}