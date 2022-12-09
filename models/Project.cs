namespace TodoApi.Models;

public class Project
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public DateTime InsertedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public required string Owner { get; set; }
}