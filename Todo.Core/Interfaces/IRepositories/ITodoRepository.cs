using Todo.Core.DomainModel;

namespace Todo.Core.Interfaces.IRepositories
{
    public interface ITodoRepository
    {
        public IEnumerable<TodoModel> FindAll();
    }
}
