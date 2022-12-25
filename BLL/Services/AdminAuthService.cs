using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminAuthService
    {
        static AdminAuthService()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
        }

        public static AdminTokenDTO Authenticate(AdminDTO user)
        {


            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
                cfg.CreateMap<AdminTokenDTO, AdminToken>();
                cfg.CreateMap<AdminToken, AdminTokenDTO>();
            }
            );

            var mapper = new Mapper(config);



            var data = mapper.Map<Admin>(user);

            var result = DataAccessFactory.AdminAuthDataAccess().Authenticate(data);
            var token = mapper.Map<AdminTokenDTO>(result);
            return token;
        }
    }
}
