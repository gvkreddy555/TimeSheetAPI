using Microsoft.AspNetCore.Mvc;
using timesheet.business;

namespace timesheet.api.controllers
{
    [Route("api/v1/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService employeeService;
        private readonly TaskService taskService;
        public EmployeeController(EmployeeService employeeService, TaskService taskService)
        {
            this.employeeService = employeeService;
            this.taskService = taskService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(employeeService.GetEmployees());
        }

        [HttpGet("gettask")]
        public IActionResult GetTasks()
        {
            return Ok(taskService.GetTasks());
        }
    }
}