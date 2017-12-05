using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ToDoList_SponServe_DAL.Repository;
using ToDoList_SponServe_Data;

namespace ToDoList_SponServe_Web.Controllers
{
    [Authorize]
    public class ToDoListController : Controller
    {
        /// <summary>
        /// Return all todos that belong to the current user
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int? categoryID)
        {

            using (CategoryRepo catRepo = new CategoryRepo())
            {
                var categories = catRepo.SelectCatByUserID(User.Identity.GetUserId());


                if (categoryID.HasValue)
                {
                    ViewBag.categoryID = categoryID.Value;
                }
                else
                {
                    ViewBag.categoryID = categories.FirstOrDefault()?.Id;
                }


                // Should return view models to view. Don't have enough time
                return View(categories);
            }

        }


        /// <summary>
        /// Add categories
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddCategory(string categoryName)
        {
            Category category = null;

            if (!String.IsNullOrEmpty(categoryName))
            {
                using (CategoryRepo catRepo = new CategoryRepo())
                {
                    category = catRepo.Insert(new Category()
                    {
                        CategoryName = categoryName,
                        UserId = User.Identity.GetUserId()
                    });

                    catRepo.Save();
                }
            }

            // Redirect to the dashboard
            return RedirectToAction("Index",new { categoryID = category?.Id});
        }


        /// <summary>
        /// Add categories
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddToDo(string toDoTitle, int categoryId, int urgency = 1)
        {

            if (!String.IsNullOrEmpty(toDoTitle))
            {
                using (ToDoRepo todoRepo = new ToDoRepo())
                {
                    todoRepo.Insert(new ToDo()
                    {
                        Title = toDoTitle,
                        CategoryId = categoryId,
                        UserId = User.Identity.GetUserId(),
                        Urgency = urgency,
                        Finished = false
                    });

                    todoRepo.Save();
                }
            }

            // Redirect to the dashboard
            return RedirectToAction("Index", new { categoryId = categoryId });
        }

       
        /// <summary>
        /// Mark a todo task complete
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MarkToDoComplete(int toDoId)
        {
            using (ToDoRepo todoRepo = new ToDoRepo())
            {
                var categoryId = todoRepo.MarkToDoComplete(toDoId);
                todoRepo.Save();

                // Redirect to the dashboard
                return RedirectToAction("Index", new { categoryID = categoryId });
            }
        }


        /// <summary>
        /// Delete a todo task 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteToDo(int toDoId, int categoryId)
        {

            using (ToDoRepo todoRepo = new ToDoRepo())
            {
                todoRepo.DeleteToDo(toDoId);
                todoRepo.Save();

                // Redirect to the dashboard
                return RedirectToAction("Index", new { categoryId = categoryId });
            }
        }
    }
}