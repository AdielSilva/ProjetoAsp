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
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Usuario usuario)
        {   

            if(ModelState.IsValid)
            {
                if (usuario.Email == "adiel.793@gmail.com" && usuario.Senha == "123")
                {
                    return RedirectToAction("index", "palavra");
                }

                else
                {
                    ViewBag.Mensagem = "deu ruim";
                    return View();
                }
               
            }

            else
            {
                ViewBag.Mensagem =  "deu ruim" ;
                return View();
            }

          
        }
    }
}
