using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tasks
    {
        public int taskId { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public DateTime hourAndDate { get; set; }
        public bool isCompleted { get; set; }
    }
}
