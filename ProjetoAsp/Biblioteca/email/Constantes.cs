using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Biblioteca.email
{
    public class Constantes
    {
        //POP3 ou IMAP = protocolo de email pra receber mensagem
        //STMP= enviar email

        //4 dados para enviar email = 

            //Autenticação gmail
        public readonly static string usuario = "adiel.793@gmail.com";
        public readonly static string Senha = "tristanet16";

        //Servidor STMP

        public readonly static string servidorSTMP = "smtp.gmail.com";
        public readonly static int portaSTMP = 465;

    }
}
