using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AIoTuesdaysReview.Models;

namespace AIoTuesdaysReview.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IoT()
        {
            return View();
        }
        public IActionResult  AI()
        {
            return View();
        }

        public IActionResult  DiscussionForum()
        {
            return View();
        }
        public IActionResult  Events()
        {
            return View();
        }
        public IActionResult  News()
        {
            return View();
        }
        public IActionResult  UserProfile()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
