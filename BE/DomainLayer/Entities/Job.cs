using Common.Enums.Job;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Job : BaseEntity<Guid>
    {
        public Guid CustomerId {  get; set; }

        public User Customer {  get; set; }

        public int? ProjectId { get; set; }

        public Guid AccountId { get; set; }

        public User AccountManager { get; set; }

        public Guid DesignedId {  get; set; }

        public User Designer {  get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public JobPriority Priority { get; set; }

        public JobStatus Status { get; set; }

        public string? Reason {  get; set; }

        public List<JobType> JobTypes { get; set; } = new List<JobType>();

        public List<JobResult> JobResults { get; set; } = new List<JobResult>();
    }
}
