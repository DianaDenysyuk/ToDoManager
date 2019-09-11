using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public enum JobStatus
    {
        Done,
        Failed,
        InProgress
    }
    public enum JobPriority
    {
        High,
        Normal,
        Low
    }
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public JobStatus Status { get; set; }
        public JobPriority Priority { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<JobTag> JobTags { get; set; }
        public Job()
        {
            JobTags = new List<JobTag>();
        }
    }
}
