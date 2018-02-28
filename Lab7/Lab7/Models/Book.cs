using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorID { get; set; }
        public string title { get; set; }
        public string isbn { get; set; }
        public string synopsis { get; set; }
        public string Description { get; set; }
        public string ImageURl { get; set; }
        public virtual Author Author { get; set; }
    }
}