using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteAspNetCore2.Models.User;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteAspNetCore2.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET /<controller>/UserAddOrUpdate
        public IActionResult UserAddOrUpdate()
        {

            return View();

        }

        // POST /<controller>/UserAddOrUpdate
        [HttpPost]
        public IActionResult UserAddOrUpdate(UserModel user)
        {
            user.CreatedDateTime = DateTime.Now;

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("0001", "Erro no modelo : UserModel.");
            }

            return View();

        }

        // POST /<controller>/Save
        [HttpPost]
        public IActionResult Save(String login, String password)
        {

            ModelState.AddModelError("abcd", "Erro no modelo");

            /*if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(login))
                    return ViewBag("");
            }
            */
            return RedirectToAction("UserAddOrUpdate");

        }
    }
}
