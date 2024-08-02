using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Company : BaseEntity<int>
    {
        public string Name { get; set; }

        public string? Address {  get; set; }

        public string? Description {  get; set; }

        public int PriceGroupId {  get; set; }

        public virtual PriceGroup PriceGroup {  get; set; }
    }
}
