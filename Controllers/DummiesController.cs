using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortoSweepstakes.Controllers
{
    public class DummiesController : Controller
    {
        public IActionResult Index()
        {
            //ViewData
            ViewData["Message"] = "This is a viewdata message";

            return View("Index");
        }
    }
}
