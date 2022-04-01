using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class StateDTO
    {
        public virtual int StateId { get; set; }
        public virtual string StateName { get; set; }
        public virtual ICollection<CityDTO> Cities { get; set; }
        public StateDTO()
        {
            Cities = new List<CityDTO>();
        }
    }
}
