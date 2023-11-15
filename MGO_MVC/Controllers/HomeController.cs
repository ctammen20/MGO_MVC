using MGO_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MGO_MVC.Controllers
{
    public class HomeController : Controller
    {

        private MGOContext Context { get; set; }
        public HomeController(MGOContext ctx)
        {
            Context = ctx;
        }
     
        public IActionResult Index()
        {


            return View();
        }

    }
}
