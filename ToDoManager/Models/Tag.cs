using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<JobTag> JobTags { get; set; }
        public Tag()
        {
            JobTags = new List<JobTag>();
        }
    }
}
