using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Models;
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


        [HttpGet]
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar([FromForm] Usuario usuario)
        {   

            if(ModelState.IsValid)
            {
                if (usuario.Email == "adiel.793@gmail.com" && usuario.Sennha == "123")
                {
                    return Redirect("google.com");
                }
            }

            else
            {
                return ViewBag.Mensagem =  "";
            }
          
        }
    }
}
