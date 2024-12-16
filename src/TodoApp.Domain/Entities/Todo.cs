namespace TodoApp.Domain.Entities;

public class Todo
{
    public Guid TodoId { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required bool Done { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}