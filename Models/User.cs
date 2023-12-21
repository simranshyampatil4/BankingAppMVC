using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingAppMVC.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual Role Role { get; set; }
        public virtual Customer Customer { get; set; }


    }
}