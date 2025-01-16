using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todolist.Models;

namespace Todolist.Controllers
{
    public class AuthController : Controller
    {

        private static readonly List<User> Users = new()

        {
            new User {Username = "admin" , Password = "1234"},
            new User {Username = "qq1" , Password = "1234"},
        };

        [Route("Auth/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Nom d'utilisateur ou mot de passe incorrect.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
