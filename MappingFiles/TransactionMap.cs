using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class TransactionMap:ClassMap<Transaction>
    {
        public TransactionMap() 
        {
            Table("Transaction");
            Id(o=>o.Id);
            Map(o => o.TransactionType);
            Map(o => o.Amount);
            Map(o => o.Date);
            Map(o => o.ToAccountNumber);
            Map(o => o.FromAccountNumber);
            References(o => o.Account).Column("AccountId");
        }
    }
}