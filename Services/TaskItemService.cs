using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    public async Task<IEnumerable<TaskItem>> GetItemAsync(bool? type)
    {
      if (type == null)
      {
        var items = await _context.Tasks.ToArrayAsync();
        return items;
      }
      else
      {
        var items = await _context.Tasks.Where(t => t.IsComplete == type).ToArrayAsync();
        return items;
      }
    }
  }
}