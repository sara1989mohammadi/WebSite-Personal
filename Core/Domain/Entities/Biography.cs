using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Biography: BaseEntity
    {
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
