using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
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

    [HttpGet("id")]
    public Project GetProject(int id)
    {
        Project project = _context.Projects
            .First(project => project.Id == id);
            
        return project;
    }

    [HttpPost]
    public Project Post(Project project)
    {
        _context.Add(project);
        _context.SaveChanges();

        return project;
    }

    [HttpDelete("{id}")]
    public ActionResult<Project> Delete(int id)
    {
        Project project = _context.Projects
            .First(project => project.Id == id);
        if (project is null)
        {
            return NotFound();
        }
        _context.Projects.Remove(project);
        _context.SaveChanges();

        return project;
    }

    [HttpPut("{id}")]
    public void Update(int id, Project project)
    {
        project.Id = id;
        _context.Projects.Update(project);
        _context.SaveChanges();
    }

}
