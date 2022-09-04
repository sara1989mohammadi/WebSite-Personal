using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Discription { get; set; }       
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string ImageUrl { get; set; }
    }
}
