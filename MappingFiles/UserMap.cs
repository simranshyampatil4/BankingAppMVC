using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("User"); 
            Id(x => x.Id);
            Map(x => x.Username); 
            Map(x => x.Password);
            HasOne(x => x.Customer).Cascade.All();
            References(x => x.Role).Column("RoleId");
        }
    }
}