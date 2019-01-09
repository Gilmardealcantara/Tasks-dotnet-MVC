using System.Collections.Generic;

namespace Tasks.Models
{
    public class TaskViewModel
    {
        public IEnumerable<TaskItem> TaskItems { get; set; }
    }
}