using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;
using ToDoList_SponServe_DAL.Repository;
using ToDoList_SponServe_Data;

namespace ToDoList_SponServe_Web.Controllers
{
    [Authorize]
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(string categoryName)
        {

            if (!String.IsNullOrEmpty(categoryName))
            {
                using (CategoryRepo todoRepo = new CategoryRepo())
                {
                    todoRepo.Insert(new Category()
                    {
                        CategoryName = categoryName,
                        UserId = User.Identity.GetUserId()
                    });


                    todoRepo.Save();
                }
            }

            return RedirectToAction("Index");
        }
    }
}