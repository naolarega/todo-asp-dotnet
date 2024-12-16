using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Presentation.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class TodoController
{
    [HttpGet]
    public void GetTodos()
    {

    }
}