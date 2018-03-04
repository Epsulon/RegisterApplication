using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using RegisterApplication.Models;
using System.Web.Mvc;
using RegisterApplication;
using Microsoft.AspNet.Identity;

namespace RegisterApplication.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();

        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult TaskList()
        {
            return View(db.SearchTitle("", User.Identity.GetUserId()));
        }

        [HttpPost]
        public ActionResult TaskList(string titleName)
        {
            return View(db.SearchTitle(titleName, User.Identity.GetUserId()));
        }


        [Authorize]
        public ActionResult Details(int id)
        {
            var task = db._AspTask.Where(p => p.Id == id).FirstOrDefault();

            TaskModelContext model = new TaskModelContext()
            {
                Id = task.Id,
                Title = task.Title,
                Tag = task.Tag,
                Completed = task.Completed,
                Description = task.Description
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Details(int id, FormCollection collection)
        {
            var task = db._AspTask.Where(p => p.Id == id).FirstOrDefault();

            TaskModelContext model = new TaskModelContext()
            {
                Id = task.Id,
                Title = task.Title,
                Tag = task.Tag,
                Completed = task.Completed,
                Description = task.Description
            };

            try
            {
                UpdateModel(task);
                db.SaveChanges();
                return View(model);
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PostManage
        [Authorize]
        public ActionResult AddNewTask()
        {
            return View();
        }

        [ValidateInput(false)]
        [HttpPost, ActionName("AddNewTask")]
        public ActionResult AddNewTask(TaskModelContext model)
        {
            if (ModelState.IsValid)
            {
                AspTask Obj = new AspTask
                {
                    Title = model.Title,
                    Tag = model.Tag,
                    Completed = model.Completed,
                    UserName = User.Identity.GetUserId(),
                    Description = model.Description
                };
                db._AspTask.Add(Obj);
                db.SaveChanges();
            }

            return View();
        }
    }
}
