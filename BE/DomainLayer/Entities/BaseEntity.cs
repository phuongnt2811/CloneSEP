using DomainLayer.Interfaces;

namespace DomainLayer.Entities
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
