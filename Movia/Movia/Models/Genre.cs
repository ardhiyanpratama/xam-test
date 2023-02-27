using System;
using System.Collections.Generic;
using System.Text;

namespace Movia.Models
{
    public class Details
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Genre
    {
        public List<Details> genres { get; set; }
    }

}
