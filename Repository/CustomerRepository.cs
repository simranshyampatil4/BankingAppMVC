using BankingAppMVC.Helpers;
using BankingAppMVC.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        public string Add(Customer customer)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Save(customer);
                    txn.Commit();

                }
            }
            return "Added Succesfully";
        }
        public string Update(Customer customer)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Update(customer);
                    txn.Commit();

                }
            }
            return "Updated Succesfully";
        }
        public string Delete(Customer customer)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Delete(customer);
                    txn.Commit();

                }
            }
            return "Deleted Succesfully";
        }
        public Customer GetById(int custId)
        {
            Customer customer = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    customer = session.Load<Customer>(custId);
                    txn.Commit();

                }
            }
            return customer;
        }
        //public List<AccountType> GetAll()
        //{
        //    List<AccountType> accountType = new List<AccountType>() { };
        //    using (var session = NHibernateHelper.OpenSession())
        //    {
        //        using (var txn = session.BeginTransaction())
        //        {
        //            accountType = session.Query<AccountType>()
        //            .Fetch(at => at.Accounts).ToList();
        //            txn.Commit();
        //        }
        //    }
        //    return accountType;
        //}
        public List<Customer> GetAll()
        {
            List<Customer> customer = new List<Customer>() { };
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    customer = session.Query<Customer>()
                        .Fetch(d => d.Documents)
                        .Fetch(d => d.Accounts)
                        .ToList();
                    txn.Commit();
                }
            }
            return customer;
        }
    }
}
