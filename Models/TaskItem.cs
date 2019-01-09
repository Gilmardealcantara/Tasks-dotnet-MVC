using System;

namespace Tasks.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public bool IsComplete { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? ConclusionDate { get; set; }
    }
}