using BankingAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppMVC.Services
{
    public interface ITransactionService
    {
        string Add(Transaction transaction);
        string Update(Transaction transaction);
        string Delete(Transaction transaction);
        Transaction GetById(int transactionId);
        List<Transaction> GetAll();
    }
}
