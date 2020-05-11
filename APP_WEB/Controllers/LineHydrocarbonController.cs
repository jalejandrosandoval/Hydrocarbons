using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APP_WEB.Controllers
{
    public class LineHydrocarbonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}