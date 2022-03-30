using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class StateDTO
    {
        public virtual int StateId { get; set; }
        public virtual int StateName { get; set; }

        public virtual ICollection<CityDTO> Citylist { get; set; }
        public StateDTO()
        {
            Citylist = new List<CityDTO>();
        }
    }
}
