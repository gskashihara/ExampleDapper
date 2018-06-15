using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Kashihara.DTO
{
    [Table("dbo.Usuario")]
    public class UsuarioDTO
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CNPJ { get; set; }

        public bool status { get; set; }
    }
}
