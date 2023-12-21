using BankingAppMVC.Models;
using BankingAppMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string Add(User user)
        {
            return _userRepository.Add(user);
        }
        public string Update(User user)
        {
            return _userRepository.Update(user);
        }
        public string Delete(User user)
        {
            return _userRepository.Delete(user);
        }
        public User GetById(int userId)
        {
            return _userRepository.GetById(userId);
        }
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}