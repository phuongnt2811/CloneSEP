using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums.Job
{
    public enum JobStatus
    {
        Pending,
        InProgress,
        Completed,
        OnHold,
        Cancelled,
        Review,
        Testing
    }
}
