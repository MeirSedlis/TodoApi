using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TodoApi.Models;

public class Project
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Owner { get; init; } = null!;
    public DateTime Inserted_at { get; init; } = DateTime.Now;
    public DateTime Updated_at { get; set; } = DateTime.Now;
    public string? Description { get; set; }
}