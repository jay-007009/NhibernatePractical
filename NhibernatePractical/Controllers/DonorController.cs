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
    public class DonorController : ControllerBase
    {
        private readonly IDonorBLL _donorServices;

        public DonorController(IDonorBLL donorServices)
        {
            _donorServices = donorServices;
        }

        // GET: api/<DonorController>
        [HttpGet]
        public IEnumerable<DonorDTO> Get()
        {
            return _donorServices.GetAllDonor();
        }

        // POST api/<DonorController>
        [HttpPost]
        public string Post([FromBody] DonorDTO donor)
        {
            return _donorServices.CreateDonor(donor);
        }


        // DELETE api/<DonorController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _donorServices.DeleteDonor(id);
        }

    }
}
