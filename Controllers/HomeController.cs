using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyWithValidations.Models;

namespace dojoSurveyWithValidations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("results", newUser);
            }
            else
            {
                return View("index");
            }
        }
        
        [HttpGet]
        [Route("/results")]
        public IActionResult Results(User newUser)
        {
            return View(newUser);
        }
    }
}