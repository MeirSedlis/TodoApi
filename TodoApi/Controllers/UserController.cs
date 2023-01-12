using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationContext _context;
    public UserController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<User>GetUser()
    {
        return _context.Users;
    }

    [HttpGet("{id}")]
    public User GetUser(int id)
    {
        User user = _context.Users
            .First(user => user.Id == id);
        
        return user;
    }

    [HttpPost]
    public User Post(User user)
    {
        _context.Add(user);
        _context.SaveChanges();

        return user;
    }

    [HttpDelete("{id}")]
    public ActionResult<User> Delete(int id)
    {
        User user = _context.Users
            .First(user => user.Id == id);
        if (user is null)
        {
            return NotFound();
        }
        _context.Users.Remove(user);
        _context.SaveChanges();

        return user;
    }

    [HttpPut("{id}")]
    public void Update(int id, User user)
    {
        user.Id = id;
        _context.Users.Update(user);
        _context.SaveChanges();
    }

}