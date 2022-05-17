using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer_BookBank.Models
{
    public class Book
    {
        //added now
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime Published { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
        public string BookDetails { get; set; }

    }
}
