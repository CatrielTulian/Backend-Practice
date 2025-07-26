using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Contract.Tasks.Request;
using Contract.Tasks.Response;
using Domain.Entities;
using Microsoft.AspNetCore.Authentication;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;


namespace To_do_List.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        
        public IActionResult CreateTask([FromBody] TaskRequest task)
        {
            _taskService.CreateTask(task);
            return Ok();
        }

        [HttpGet]
        
        public IActionResult GetAllTasK()
        {
            var response = _taskService.GetAllTasks();
            if (response.Count is 0)
            {
                return NotFound("There are no tasks loaded in the database");
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        
        public ActionResult<TaskResponse?> GetTaskById([FromRoute] int Id)
        {
            var response = _taskService.GetTaskById(Id);
            if (response is null)
            {
                return NotFound("There is no task with that ID number.");
            }
            return Ok(response);
        }

        [HttpPut("{id}")]
        
        public ActionResult<bool> UpdateTask([FromRoute] int Id, [FromBody] TaskRequest task)
        {
            return Ok(_taskService.UpdateTask(Id, task));
        }

        [HttpDelete]
        
        public ActionResult<bool> DeleteTask([FromRoute] int Id) 
        {
            return Ok(_taskService.DeleteTask(Id));
        }
    }
}
