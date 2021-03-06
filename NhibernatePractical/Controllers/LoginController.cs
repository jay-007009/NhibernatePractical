using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.BLL.InterFaces;
using NhibernatePractical.DLL.Interfaces;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginBLL _userServices;

        public LoginController(ILoginBLL userServices)
        {
            _userServices = userServices;
        }

        // POST api/<LoginController>
        [HttpPost]
        public string Post([FromBody] string userName, string password)
        {
            if (_userServices.CheckUserActive(userName, password))
            {
                return "Login Successfully.....";
            }
            else
            {
                return "Login Failed  User Not Active....";
            }
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
             _userServices.CheckIsActive(id);
        }



    }
}
