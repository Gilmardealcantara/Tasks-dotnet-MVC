using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.Controllers
{
  public class TasksController: Controller
  {
    ITaskItemService _taskService; 
    public TasksController(ITaskItemService taskService)
    {
        _taskService = taskService;
    }

    public async Task<IActionResult> Index()
    {
      var tasks = await _taskService.GetItemAsync();

      var model = new TaskViewModel();
      {
        model.TaskItems = tasks;
      }
      return View(model) ;
    }
  }
}
