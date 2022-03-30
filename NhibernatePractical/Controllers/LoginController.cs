using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhibernatePractical.DLL.Interfaces;
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
        private readonly ILogin _userServices;

        public LoginController(ILogin userServices)
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
        public bool Put(int id)
        {
            return _userServices.CheckIsActive(id);
        }



    }
}
