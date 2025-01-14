using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todolist.Models;

namespace Todolist.Controllers
{
    public class TodolistController : Controller
    {
        // Liste statique de contacts
        private static List<TaskModel> contacts = new List<TaskModel>
        {
            new TaskModel { Id = 1, Name = "Planning", Description = "hfghbrththbrthntrgfnfjnthht", status = "done" },
            new TaskModel { Id = 2, Name = "Shopping", Description = "htghtrsjntrhjrhthtrhtrhtrh", status = "todo" },
            new TaskModel { Id = 3, Name = "Dishwashing", Description = "hhbqehrqeherghbrzGfeztgeztg", status = "todo" }
        };


        // GET: Todolist
        public ActionResult Index()
        {
            return View();
        }

        // GET: Todolist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todolist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todolist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todolist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todolist/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todolist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todolist/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
