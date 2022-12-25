using BLL.DTOs;
using BLL.Services;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace server.Controllers
{
    [RoutePrefix("api")]
    public class AuthController : ApiController
    {
        [Route("customerLogin")]
        [HttpGet]

        public HttpResponseMessage CustomerLogin(CustomerDTO user)
        {
            var token = CustomerAuthService.Authenticate(user);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }

        [Route("adminLogin")]
        [HttpGet]

        public HttpResponseMessage AdminLogin(AdminDTO admin)
        {
            var token = AdminAuthService.Authenticate(admin);

            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }

        [Route("specialistLogin")]
        [HttpGet]

        public HttpResponseMessage SpecialistLogin(SpecialistDTO user)
        {
            var token = SpecialistAuthService.Authenticate(user);

            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);

            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }


    }
}
