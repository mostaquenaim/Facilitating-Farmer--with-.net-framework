using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        static AuthService()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
        }

        public static CustomerTokenDTO Authenticate(CustomerDTO user)
        {
            

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
                cfg.CreateMap<CustomerTokenDTO, CustomerToken>();
                cfg.CreateMap<CustomerToken, CustomerTokenDTO>();
            }
            );

            var mapper = new Mapper(config);
            

            
            var data = mapper.Map<Customer>(user);

            var result= DataAccessFactory.AuthDataAccess().Authenticate(data);
            var token= mapper.Map<CustomerTokenDTO>(result);
            return token;
        }
    }
}
