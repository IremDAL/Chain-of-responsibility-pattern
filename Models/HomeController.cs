using Microsoft.AspNetCore.Mvc;
using message.Models;
using System.Collections.Generic;

namespace message.Controllers
{
    public class HomeController : Controller
    {
        private readonly ErrorHandler _errorHandler;

        public HomeController(ErrorHandler errorHandler)
        {
            _errorHandler = errorHandler;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string message)
        {
            var log = new List<string>();
            _errorHandler.Handle(message, log);
            ViewBag.Log = log;
            return View();
        }
    }
}
