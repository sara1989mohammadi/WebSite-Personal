using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public  class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public string Publisher { get; set; }
        public string DatePublisher { get; set; }
        public string ImageUrl { get; set; }
    }
}
