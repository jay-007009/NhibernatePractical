using FluentNHibernate.Mapping;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.NhibernateMapping
{
    public class LoginMap : ClassMap<UserDTO>
    {

        public LoginMap()
        {
            Table("UserLogin");
            Id(x => x.UserId);
           
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.IsActive);
            HasMany(x => x.FirmList).KeyColumn("UserId").Inverse().Fetch.Join().AsSet().Not.LazyLoad();
        }
    }
}
