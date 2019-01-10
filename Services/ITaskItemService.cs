using System.Threading.Tasks;
using System.Collections.Generic;
using Tasks.Models;

namespace Tasks.Services
{
    public interface ITaskItemService
    {
         Task<IEnumerable<TaskItem>> GetItemAsync(bool? type);
    }
}