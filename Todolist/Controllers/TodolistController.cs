using System.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todolist.Models;

namespace Todolist.Controllers
{
    public class TodolistController : Controller
    {
        // Liste statique de tâches
        private static List<TaskModel> tasks = new List<TaskModel>
        {
            new TaskModel { Id = 1, Name = "Planning", Description = "hfghbrththbrthntrgfnfjnthht", Status = "done" },
            new TaskModel { Id = 2, Name = "Shopping", Description = "htghtrsjntrhjrhthtrhtrhtrh", Status = "todo" },
            new TaskModel { Id = 3, Name = "Dishwashing", Description = "hhbqehrqeherghbrzGfeztgeztg", Status = "todo" }
        };

        private readonly DbContext _dbContext;

        public TodolistController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: Todolist
        public IActionResult Index()
        {
            return View(tasks);
        }

        // GET: Todolist/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Todolist/Form
        [Route("Todolist/Form")]
        public IActionResult Form()
        {
            return View();
        }

        // POST: Todolist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todolist/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todolist/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
