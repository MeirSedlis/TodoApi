using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{
    private readonly ApplicationContext _context;
    public ProjectController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Project> GetProjects()
    {
        return _context.Projects;
    }

    [HttpPost]
    public Project Post(Project project)
    {
        _context.Add(project);
        _context.SaveChanges();

        return project;
    }

}
