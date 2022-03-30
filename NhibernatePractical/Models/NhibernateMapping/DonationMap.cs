using FluentNHibernate.Mapping;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.NhibernateMapping
{
    public class DonationMap : ClassMap<DonorDTO>
    {
        public DonationMap()
        {
            Table("Donor");
            Id(x => x.DonorId);
            Map(x => x.DonorName);
            Map(x => x.AddressLine1);
            Map(x => x.AddressLine2);
            Map(x => x.DonorCityName);
            Map(x => x.DonorStateName);
            Map(x => x.DonationAmount);
            Map(x => x.MobileNo);
            Map(x => x.FirmId);
            References(x => x.FirmList).Column("FirmId").Fetch.Join();
          
        }
    }
}
