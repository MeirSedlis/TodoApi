using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoItemController : ControllerBase
{
    private readonly ApplicationContext _context;
    public TodoItemController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<TodoItem> GetTodoItems()
    {
        return _context.TodoItems;
    }

    [HttpGet("{id}")]
    public TodoItem GetTodoItem(int id)
    {
        TodoItem todoItem = _context.TodoItems
            .First(todoItem => todoItem.Id == id);
            
        return todoItem;
    }

    [HttpPost]
    public TodoItem Post(TodoItem todoItem)
    {
        _context.Add(todoItem);
        _context.SaveChanges();

        return todoItem;
    }

    [HttpDelete("{id}")]
    public ActionResult<TodoItem> Delete(int id)
    {
        TodoItem todoItem = _context.TodoItems
            .First(todoItem => todoItem.Id == id);
        if (todoItem is null)
        {
            return NotFound();
        }
        _context.TodoItems.Remove(todoItem);
        _context.SaveChanges();

        return todoItem;
    }

    [HttpPut("{id}")]
    public void Update(int id, TodoItem todoItem)
    {
        todoItem.Id = id;
        _context.TodoItems.Update(todoItem);
        _context.SaveChanges();
    }

}
