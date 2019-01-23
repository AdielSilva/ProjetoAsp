using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Models
{
    public class Usuario
    {
        [Required (ErrorMessage = "Email inválido otário")]
        [EmailAddress(ErrorMessage ="Email inválido otário")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }      


    }
}
