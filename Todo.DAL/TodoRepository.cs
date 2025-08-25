using Todo.Core.DomainModel;
using Todo.Core.Interfaces.IRepositories;
namespace Todo.DAL
{
    public class TodoRepository : ITodoRepository
    {

        private static Dictionary<int, TodoModel>? _todoDb;

        public TodoRepository()
        {
            _todoDb = new Dictionary<int, TodoModel>();

            _todoDb.Add(1, new TodoModel
            {
                Title = "Test1",
                Description = "Test1",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                IsDone = false,
            });
            
            _todoDb.Add(2, new TodoModel
            {
                Title = "Test2",
                Description = "Test2",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                IsDone = false,
            });
        }

        public IEnumerable<TodoModel> FindAll() { return _todoDb.Values.ToList(); }
        //Add
        //Remove
        //Update
    }
}
