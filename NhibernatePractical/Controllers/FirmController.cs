using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class FirmController : ControllerBase
    {
        private readonly IFirm _firmServices;

        public FirmController(IFirm firmServices)
        {
            _firmServices = firmServices;
        }

        // GET: api/<FirmController>
        [HttpGet]
        public IEnumerable<FirmDTO> Get()
        {
            return _firmServices.GetAllFirm();
        }

        // GET api/<FirmController>/5
        [HttpGet("{id}")]
        public FirmDTO Get(int id)
        {
            return _firmServices.GetFirmWithId(id);
        }

        // POST api/<FirmController>
        [HttpPost]
        public string Post([FromBody] FirmDTO firms)
        {
            return _firmServices.CreateFirm(firms);
        }

        // PUT api/<FirmController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] FirmDTO firm)
        {
            return _firmServices.UpdateFirm(id, firm);
        }

        // DELETE api/<FirmController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _firmServices.DeleteFirm(id);
        }


    }
}
