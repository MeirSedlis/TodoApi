using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Notes {get; set;}
    public int? Priority {get; set; }
    public DateTime InsertedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
    public DateTime Due {get; set;}
    public int ProjectID {get; set;}
    [ForeignKey ("project")]
    public required Project project {get; set;}

}