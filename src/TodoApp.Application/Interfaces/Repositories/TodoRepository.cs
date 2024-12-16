using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces.Repositories;

public interface ITodoRepository
{
    ICollection<Todo> GetAllTodo();
}