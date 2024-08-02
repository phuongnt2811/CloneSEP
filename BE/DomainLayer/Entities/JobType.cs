﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class JobType : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Job> Jobs { get; set; } = new List<Job>();
    }
}
