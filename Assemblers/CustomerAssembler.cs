using BankingAppMVC.Helpers;
using BankingAppMVC.Models;
using BankingAppMVC.ViewModels;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Assemblers
{
    public class CustomerAssembler
    {
        public  Customer ConvertToModel(CustomerVM customerVM)
        {
            return new Customer
            {
                FirstName = customerVM.FirstName,
                LastName = customerVM.LastName,
                ContactNo = customerVM.ContactNo,
                Email = customerVM.Email,
                Status = customerVM.Status,
                User = new User() { Id = customerVM.UserId },
            };
        }

        public  CustomerVM ConvertToViewModel(Customer customer)
        {
            return new CustomerVM
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                ContactNo = customer.ContactNo,
                Email = customer.Email,
                Status = customer.Status,
                DocumentsCount = customer.Documents != null ? customer.Documents.Count : 0,
                AccountsCount = customer.Accounts != null ? customer.Accounts.Count : 0,
            };
        }
    }
}