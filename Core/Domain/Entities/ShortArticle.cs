﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShortArticle : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
      
    }
}
