using System.Collections.Generic;
using Kashihara.DTO;
using System.Data.SqlClient;
using Kashihara.DAO.Connection;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Kashihara.DAO
{
    public class UsuarioDAO
    {
        public IEnumerable<UsuarioDTO> GetAll()
        {
            using (SqlConnection conn = ConnectionFactory.GetSqlConnection())
            {
                return conn.GetAll<UsuarioDTO>();
            }
        }

        public UsuarioDTO GetUser(int id)
        {
            using (SqlConnection conn = ConnectionFactory.GetSqlConnection())
            {
                return conn.Get<UsuarioDTO>(id);
            }

        }

        public UsuarioDTO SaveUser(UsuarioDTO usuario)
        {
            using (SqlConnection conn = ConnectionFactory.GetSqlConnection())
            {
                usuario.IdUsuario = (int)conn.Insert(usuario);
            }

            return usuario;
        }
    }
}
