using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return new ContentResult() { Content = "Mundanças ", ContentType = " text/plain" };

            return View(); 
        }
    }
}
