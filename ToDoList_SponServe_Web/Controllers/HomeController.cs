using System.Web.Mvc;

namespace ToDoList_SponServe_Web.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Redirect to to-do list dashboard if authenticated
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index","ToDoList");
            }

            return View();
        }

        /// <summary>
        /// Static page that explains the design of this app.
        /// </summary>
        /// <returns></returns>
        public ActionResult Design()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Static page that records time used on each part of the app.
        /// </summary>
        /// <returns></returns>
        public ActionResult TimeSheet()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}