﻿using BankingAppMVC.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.MappingFiles
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Table("Role"); 
            Id(x => x.Id);
            Map(x => x.RoleName); 
            HasMany(x => x.Users).Inverse().Cascade.SaveUpdate().KeyColumn("RoleId");
        }
    }
}