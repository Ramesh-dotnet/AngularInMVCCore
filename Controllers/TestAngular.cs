using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularInMVCCore.Controllers
{
    public class TestAngular : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
