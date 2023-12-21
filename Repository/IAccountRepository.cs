﻿using BankingAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppMVC.Repository
{
    public interface IAccountRepository
    {
        string Add(Account account);
        string Update(Account account);
        string Delete(Account account);
        Account GetById(int accountId);
        List<Account> GetAll();
    }
}
