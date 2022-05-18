using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer_BookBank.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Book Book { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
