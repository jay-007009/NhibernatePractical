using FluentNHibernate.Mapping;
using NhibernatePractical.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.NhibernateMapping
{
    public class StateMap : ClassMap<StateDTO>
    {
        public StateMap()
        {
            Table("State");
            Id(x => x.StateId);
            Map(x => x.StateName);
            HasMany(x => x.Cities).KeyColumn("StateId").Inverse().Cascade.All().Fetch.Join().AsSet().Not.LazyLoad();
        }
    }
}
