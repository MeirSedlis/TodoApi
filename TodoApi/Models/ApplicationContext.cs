using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

    public class ApplicationContext : DbContext
{
    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}

