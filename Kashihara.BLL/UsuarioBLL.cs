using Kashihara.DAO;
using Kashihara.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kashihara.BLL
{
    public class UsuarioBLL
    {
        public List<UsuarioDTO> GetAll()
        {
            var usuarioDAO = new UsuarioDAO();

            return usuarioDAO.GetAll().ToList();

        }

        public UsuarioDTO GetUser(int id)
        {
            var usuarioDAO = new UsuarioDAO();

            return usuarioDAO.GetUser(id);

        }

        public UsuarioDTO SaveUser(UsuarioDTO user)
        {
            var usuarioDAO = new UsuarioDAO();

            return usuarioDAO.SaveUser(user);
        }
    }
}
