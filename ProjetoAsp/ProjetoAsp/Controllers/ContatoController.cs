using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Models;
using System.Web.Http;
using System.Net;

namespace ProjetoAsp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Obtendo manualmente 
        public IActionResult ReceberContato()
        {
            //Post = Request.Form
            //Get = Request.QueryString

            Contato contato = new Contato();

            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["mensagem"];

            if(ModelState.IsValid)
            {
                string conteudo = String.Format("Nome: {0} \nE-mail: {1} \nAssunto: {2} \nMensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                return new ContentResult() { Content = conteudo };
            }

            else
            {
                return View("Index");
            }

           
        }
       
    }
}
