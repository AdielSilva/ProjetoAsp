using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAsp.Models
{
    public class Contato
    {   
        [Required]
        [MaxLength (50) ]
        public string Nome { get; set; }

        [Required]
        [MaxLength (70)]
        public string Email { get; set; }

        [Required]
        [MaxLength(70)]
        [EmailAddress]
        public string Assunto { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Mensagem { get; set; }



    }
}
