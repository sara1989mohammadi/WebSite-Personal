using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CV : BaseEntity
    {
        public string Title { get; set; }
        public string University { get; set; }
        public string Grade { get; set; }
    }
}
