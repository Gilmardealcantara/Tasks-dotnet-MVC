using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tasks.Models;

namespace Tasks.Services
{
  public class TempTaskItemService : ITaskItemService
  {
    public Task<IEnumerable<TaskItem>> GetItemAsync(bool? type)
    {
      IEnumerable<TaskItem> items = new[]
      {
            new TaskItem
            {
                Name = "Learn ASP NET 2",
                IsComplete = false,
                ConclusionDate = DateTimeOffset.Now.AddDays(20)
            },         
            new TaskItem
            {
                Name = "Create Wep app",
                IsComplete = false,
                ConclusionDate = DateTimeOffset.Now.AddDays(60)
            }
        };
      return Task.FromResult(items);
    }
  }
}