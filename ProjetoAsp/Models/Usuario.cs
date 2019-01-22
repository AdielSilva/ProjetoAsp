using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAsp.Models
{
    public class Usuario
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Sennha { get; set; }


    }
}
