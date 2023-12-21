using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("Customer");
            Id(o => o.Id);
            Map(o => o.FirstName);
            Map(o => o.LastName);
            Map(o => o.ContactNo);
            Map(o => o.Email);
            Map(o => o.Status);
            References(m => m.User).Columns("UserId");
            HasMany(m => m.Documents).Inverse().Cascade.SaveUpdate().KeyColumn("CustomerId");
            HasMany(m => m.Accounts).Inverse().Cascade.SaveUpdate().KeyColumn("CustomerId");
        }
    }
}