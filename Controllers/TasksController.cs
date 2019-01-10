using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
  [Authorize]
  public class TasksController : Controller
  {
    ITaskItemService _taskService;
    private readonly UserManager<IdentityUser> _userManager;
    public TasksController(ITaskItemService taskService,
                           UserManager<IdentityUser> userManager)
    {
      _taskService = taskService;
      _userManager = userManager;
    }

    public async Task<IActionResult> Index(bool? type)
    {
      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null)
        return Challenge();

      var tasks = await _taskService.GetItemAsync(type, currentUser);
      var model = new TaskViewModel();
      {
        model.TaskItems = tasks;
      }
      return View(model);
    }

    public async Task<IActionResult> CreateTasksforUser()
    {
      var currentUser = await _userManager.GetUserAsync(User);
      var taskAdded = await _taskService.CreateTaskAsync(currentUser);
      return Json(taskAdded);
    }
  }
}
