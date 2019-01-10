using System.Threading.Tasks;
using System.Collections.Generic;
using Tasks.Models;
using Microsoft.AspNetCore.Identity;

namespace Tasks.Services
{
    public interface ITaskItemService
    {
         Task<IEnumerable<TaskItem>> GetItemAsync(bool? type, IdentityUser user);
         Task<IEnumerable<TaskItem>> CreateTaskAsync(IdentityUser user);
    }
}