using Microsoft.AspNetCore.Mvc;
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

    public IActionResult Index()
    {
      var tasks = _taskService.GetItemAsync();
      return View(tasks);
    }
  }
}
