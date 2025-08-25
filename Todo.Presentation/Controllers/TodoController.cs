using Microsoft.AspNetCore.Mvc;
using Todo.Core.Interfaces.IServices;

namespace Todo.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var todos = _todoService.GetAll();

            return Ok(todos);
        }
    }
}
