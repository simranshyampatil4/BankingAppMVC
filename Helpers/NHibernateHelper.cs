using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BankingAppMVC.MappingFiles;

namespace BankingAppMVC.Helpers
{
    internal class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory=null;
        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory=Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString("Data Source=ACER1195;Initial Catalog=BankingApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                    .Mappings(m=>m.FluentMappings.Add<AccountMap>())
                    .Mappings(m => m.FluentMappings.Add<CustomerMap>())
                    .Mappings(m => m.FluentMappings.Add<DocumentMap>())
                    .Mappings(m => m.FluentMappings.Add<RoleMap>())
                    .Mappings(m => m.FluentMappings.Add<TransactionMap>())
                    .Mappings(m => m.FluentMappings.Add<UserMap>())
                    .Mappings(m => m.FluentMappings.Add<AccountTypeMap>())
                    .BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }
    }
}
