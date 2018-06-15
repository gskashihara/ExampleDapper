using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kashihara.Web.Api.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public string CNPJ { get; set; }

        public bool status { get; set; }
    }
}