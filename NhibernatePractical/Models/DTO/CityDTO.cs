using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class CityDTO
    {
        public virtual int CityId { get; set; }
        public virtual string CityName { get; set; }
        public virtual int StateId { get; set; }
        public virtual StateDTO States { get; set; }
    }
}
