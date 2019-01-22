using ProjetoAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ProjetoAsp.Biblioteca.email
{
    public class EnviarEmail
    { 
        public static void enviarMensagemContato(Contato contato)
        {
            //Configurar servidor e construir uma mensagem

            SmtpClient smtp = new SmtpClient(Constantes.servidorSTMP, Constantes.portaSTMP);

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential( Constantes.usuario, Constantes.Senha);

            string conteudo = "Parabéns pelo primeiro email enviado através da linguagem asp";
            //Mensagem de email

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(Constantes.usuario);
            mensagem.To.Add("adiel.793@gmail.com");
            mensagem.Subject = "Teste";
            mensagem.IsBodyHtml = true;

            mensagem.Body = "<h1>Primeiro email através de programação</h1> " + conteudo;

            smtp.Send(mensagem);
        }
    }
}
