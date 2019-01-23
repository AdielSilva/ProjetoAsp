using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Database;
using ProjetoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Controllers
{
    public class PalavraController : Controller
    {
        private DataBaseContext _db;
        public PalavraController(DataBaseContext db)
        {
            _db = db;
        }

        //Listar todas as palavras do Banco de Dados
        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();

            return View(palavras);
        }

        //CRUD
        
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Palavra());
          
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            if(ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);

                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);



            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            if(ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Cadastrar", palavra);
        }

     
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Index");
        }

   
    }
}
