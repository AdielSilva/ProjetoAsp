using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Models;
using System.Web.Http;
using System.Net;
using ProjetoAsp.Biblioteca.email;

namespace ProjetoAsp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            //Post = Request.Form
            //Get = Request.QueryString        

            if(ModelState.IsValid)
            {
                string conteudo = String.Format("Nome: {0} \nE-mail: {1} \nAssunto: {2} \nMensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                             
                EnviarEmail.enviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso";

                return new ContentResult() { Content = conteudo };
            }

            else
            {
                return View("Index");
            }

           
        }
       
    }
}
