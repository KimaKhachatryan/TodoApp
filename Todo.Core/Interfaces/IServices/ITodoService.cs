using Todo.Core.DomainModel;
using Todo.Core.Interfaces.IRepositories;

namespace Todo.Core.Interfaces.IServices
{
    public interface ITodoService
    {
        IEnumerable<TodoModel> GetAll();
    }
}
