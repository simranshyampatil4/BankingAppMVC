using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Table("Document");
            Id(m => m.Id);
            Map(m => m.DocumentName);
            Map(m => m.DocumentFile);
            References(m => m.Customer).Column("CustomerId");
        }
    }
}