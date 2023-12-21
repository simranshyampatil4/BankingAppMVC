using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Table("Account");
            Id(o => o.Id);
            Map(o => o.AccountNo);
            Map(o => o.Balance);
            Map(o => o.Status);
            References(m => m.AccountType).Column("AccountTypeId");
            References(m => m.Customer).Column("CustomerId");
        }
    }
}