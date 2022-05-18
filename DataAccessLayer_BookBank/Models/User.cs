using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer_BookBank.Models
{
    public class User
    {
        //adding sagar
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> order { get; set; }

    }
}
