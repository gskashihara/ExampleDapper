using Kashihara.BLL;
using Kashihara.DTO;
using Kashihara.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kashihara.Web.Api.Controllers
{
    [RoutePrefix("api/v1/users")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var usuarioBLL = new UsuarioBLL();
                var user = usuarioBLL.GetAll();

                return Request.CreateResponse(HttpStatusCode.OK, AutoMapper.Mapper.Map<List<UsuarioDTO>, List<UsuarioViewModel>>(user));

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("{idUsuario:int}")]
        public HttpResponseMessage GetUsuario(int idUsuario)
        {
            try
            {
                var usuarioBLL = new UsuarioBLL();

                var user = usuarioBLL.GetUser(idUsuario);

                if (user == null)
                {
                    var message = string.Format("User with id = {0} not found", idUsuario);
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }

                return Request.CreateResponse(HttpStatusCode.OK, AutoMapper.Mapper.Map<UsuarioDTO,UsuarioViewModel>(user));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }


        [HttpPost]
        [Route("")]
        public HttpResponseMessage Save(UsuarioViewModel usuario)
        {
            try
            {
                if(usuario == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"User required");
                }

                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

                var usuarioBLL = new UsuarioBLL();

                var userDTO = usuarioBLL.SaveUser(AutoMapper.Mapper.Map<UsuarioViewModel, UsuarioDTO>(usuario));

                usuario.IdUsuario = userDTO.IdUsuario;

                return Request.CreateResponse(HttpStatusCode.OK,usuario);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
    }
}
