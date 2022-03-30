using FluentNHibernate.Mapping;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.NhibernateMapping
{
    public class CityMap : ClassMap<CityDTO>
    {

        public CityMap()
        {
            Table("City");
            Id(x => x.CityId);
            Map(x => x.CityName);
            References(x => x.StateList).Column("StateId").Fetch.Join();

           
        }
    }
}
