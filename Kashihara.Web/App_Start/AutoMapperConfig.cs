using Kashihara.DTO;
using Kashihara.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kashihara.Web.Api.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UsuarioDTO, UsuarioViewModel>();
                cfg.CreateMap<UsuarioViewModel, UsuarioViewModel>();
            });
        }

    }
}