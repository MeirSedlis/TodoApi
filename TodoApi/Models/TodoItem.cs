using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TodoApi.Models;

public class TodoItem
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public Project Project { get; set; } = null!;
    public bool Is_complete { get; set; }
    public DateTime Inserted_at { get; init; } = DateTime.Now;
    public DateTime Updated_at { get; set; } = DateTime.Now;
    public string? Description { get; set; }
    public int Priority { get; set; } = 3;
}