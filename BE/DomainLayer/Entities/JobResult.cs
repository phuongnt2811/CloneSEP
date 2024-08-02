using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class JobResult: BaseEntity<int>
    {
        public Guid JobId { get; set; }

        public virtual Job Job { get; set; }

        public byte[] Result { get; set; }

    }
}
