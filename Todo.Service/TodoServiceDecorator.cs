using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Core.DomainModel;
using Todo.Core.Interfaces.IServices;

namespace Todo.Service
{
    public class TodoServiceDecorator : ITodoService
    {
        private readonly ITodoService _inner;

        public TodoServiceDecorator(ITodoService inner)
        {
            _inner = inner;
        }

        public IEnumerable<TodoModel> GetAll()
        {
            Console.WriteLine("Decorator....");
            return _inner.GetAll();
        }
    }
}
