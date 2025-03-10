﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todolist.Data;
using Todolist.Models;

namespace Todolist.Controllers
{
    public class TodolistController : Controller
    {
        // Liste statique de tâches
        //private static List<TaskModel> tasks = new List<TaskModel>
        //{
        //    new TaskModel { Id = 1, Name = "Planning", Description = "hfghbrththbrthntrgfnfjnthht", Status = "done" },
        //    new TaskModel { Id = 2, Name = "Shopping", Description = "htghtrsjntrhjrhthtrhtrhtrh", Status = "todo" },
        //    new TaskModel { Id = 3, Name = "Dishwashing", Description = "hhbqehrqeherghbrzGfeztgeztg", Status = "todo" }
        //};

        private readonly ApplicationDbContext _dbContext;

        public TodolistController(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }


        // GET: Todolist
        public IActionResult Index()
        {
            var todo = _dbContext.myTask.ToList();
            return View(todo);
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
        public IActionResult Create(TaskModel taskModel)
        {
            if (ModelState.IsValid)
            {
                _dbContext.myTask.Add(taskModel);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View();
            
        }

        // POST: Todolist/Edit/5
        public IActionResult Edit(int id)
        {
            var todo = _dbContext.myTask.Find(id);
            if (todo != null)
            {
                _dbContext.myTask.Update(todo);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Form));
            }

            return View();
        }

        // POST: Todolist/Delete/5
        public IActionResult Delete(int id)
        {
            var todo = _dbContext.myTask.Find(id);
            if (todo != null)
            {
                _dbContext.Remove(todo);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
