using BankingAppMVC.Models;
using BankingAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Assemblers
{
    public class UserAssembler
    {
        public User ConvertToModel(UserVM userVM)
        {
            return new User()
            {
                Id = userVM.Id,
                Username = userVM.Username,
                Password = userVM.Password,
                Role = new Role() { Id = userVM.RoleId },
            };
        }
        public UserVM ConvertToViewModel(User user)
        {
            return new UserVM()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                RoleId = user.Role.Id,
            };
        }
    }
}