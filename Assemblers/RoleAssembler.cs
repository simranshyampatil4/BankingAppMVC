using BankingAppMVC.Models;
using BankingAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Assemblers
{
    public class RoleAssembler
    {
        public Role ConvertToModel(RoleVM roleVM)
        {
            return new Role()
            {
                Id = roleVM.Id,
                RoleName = roleVM.RoleName,
            };
        }
        public RoleVM ConvertToViewModel(Role role)
        {
            return new RoleVM()
            {
                Id = role.Id,
                RoleName = role.RoleName,
                UsersCount = role.Users != null ? role.Users.Count : 0,
            };
        }
    }
}