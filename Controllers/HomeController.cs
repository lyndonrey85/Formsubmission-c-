using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Formsubmission.Models;

namespace Formsubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = ModelState.Values;
            return View();
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(string first, string last, int age, string email, string password)
        {
            User newUser = new User
            {
                firstName = first,
                lastName = last,
                age = age,
                email = email,
                password = password
            };
            if(TryValidateModel(newUser) == false)
            {
                ViewBag.Errors = ModelState.Values;
                return View("Index");
            }
            return RedirectToAction("Success");
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}