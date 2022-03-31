using FluentNHibernate.Mapping;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.NhibernateMapping
{
    public class FirmMap : ClassMap<FirmDTO>
    {
        public FirmMap()
        {
            Table("Firm");
            Id(x => x.FirmId);

            Map(x => x.FirmName);
            Map(x => x.RegisterNo);
            Map(x => x.RegisterDate);
            Map(x => x.DonationLimit);
            Map(x => x.AddressLine1);
            Map(x => x.AddressLine2);
            Map(x => x.CreationDate);
            Map(x => x.ModificationDate);
            Map(x => x.FirmCityName);
            Map(x => x.FirmStateName);
            Map(x => x.UserId);

            References(x => x.UserList).Column("UserId").Fetch.Join();
       
            HasMany(x => x.DonorList).KeyColumn("FirmId").Inverse().Fetch.Join().AsSet().Not.LazyLoad();
        }
    }
}
