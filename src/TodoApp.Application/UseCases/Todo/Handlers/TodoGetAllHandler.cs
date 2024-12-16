using TodoApp.Application.Interfaces.Repositories;

namespace TodoApp.Application.UseCases.Todo;

public class TodoGetAllHandler(ITodoRepository todoRepository)
{
    public ICollection<TodoGetAllQuery> Handle()
    {
        todoRepository.GetAllTodo();

        throw new NotImplementedException();
    }
}