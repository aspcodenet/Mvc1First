using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1First.Controllers
{
    public class SoccerController : Controller
    {
        // /soccer/index
        // /soccer
        public IActionResult Index()
        {
            return View();
        }
    }
}
