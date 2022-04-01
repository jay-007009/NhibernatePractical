using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NhibernatePractical.Models.NhibernateMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical
{
    public class NHibernateSession
    {

        public static ISession OpenSession()
        {
            string connectionString = "Data Source=.;Initial Catalog=DonationDB;Integrated Security=True";

            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(connectionString).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<LoginMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FirmMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DonationMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StateMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CityMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();

        }
    }
}
