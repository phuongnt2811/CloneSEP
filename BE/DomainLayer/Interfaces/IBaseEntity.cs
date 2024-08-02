using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }

        Guid? CreatedBy { get; set; }

        DateTime CreateDate { get; set; }

        DateTime UpdateDate { get; set; }
    }
}
