using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class ApplicationContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public ApplicationContext()
    {

    }
    public ApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionstring = _configuration.GetConnectionString("ApplicationContext");
       optionsBuilder.UseNpgsql(connectionstring);
    }

}

