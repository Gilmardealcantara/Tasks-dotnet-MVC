using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tasks.Data;
using Tasks.Models;

namespace Tasks.Services
{
  public class TaskItemService : ITaskItemService
  {

    private readonly ApplicationDbContext _context;
    public TaskItemService(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<TaskItem>> GetItemAsync(bool? type, IdentityUser user)
    {
      if (type == null)
      {
        var items = await _context.Tasks.Where(t => t.OwnerId == user.Id).ToArrayAsync();
        return items;
      }
      else
      {
        var items = await _context.Tasks.Where(t => t.IsComplete == type && t.OwnerId == user.Id).ToArrayAsync();
        return items;
      }
    }

    public async Task<IEnumerable<TaskItem>> CreateTaskAsync(IdentityUser user)
    {
      List<TaskItem> items = new List<TaskItem>();
      

      for (int i = 0; i < 10; i++)
      {
        items.Add(
          new TaskItem
          {
            Name = "Task of " + user.UserName + " --" + i,
            IsComplete = (i%2) != 0,
            OwnerId = user.Id,
            ConclusionDate = DateTimeOffset.Now
          }
        );
      }
      _context.Tasks.AddRange(items);
      var result = await _context.SaveChangesAsync();
      Console.Write("Add new Tasks");
      Console.Write(result);
      return items;
    }
  }
}