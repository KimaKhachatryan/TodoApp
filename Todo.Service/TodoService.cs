using Todo.Core.DomainModel;
using Todo.Core.Interfaces.IRepositories;
using Todo.Core.Interfaces.IServices;

namespace Todo.Service
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoService;

        public TodoService(ITodoRepository todoService)
        {
            _todoService = todoService;
        }

        public IEnumerable<TodoModel> GetAll()
        {
            return _todoService.FindAll();
        }
    }
}
