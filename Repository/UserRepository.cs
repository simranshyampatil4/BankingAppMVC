using BankingAppMVC.Helpers;
using BankingAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Repository
{
    public class UserRepository:IUserRepository
    {
        public string Add(User user)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Save(user);
                    txn.Commit();

                }
            }
            return "Added Succesfully";
        }
        public string Update(User user)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Update(user);
                    txn.Commit();

                }
            }
            return "Updated Succesfully";
        }
        public string Delete(User user)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    session.Delete(user);
                    txn.Commit();

                }
            }
            return "Deleted Succesfully";
        }
        public User GetById(int userId)
        {
            User user = null;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    user = session.Load<User>(userId);
                    txn.Commit();

                }
            }
            return user;
        }
        public List<User> GetAll()
        {
            List<User> user = new List<User>() { };
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var txn = session.BeginTransaction())
                {
                    user = session.Query<User>().ToList();
                    txn.Commit();
                }
            }
            return user;
        }
    }
}