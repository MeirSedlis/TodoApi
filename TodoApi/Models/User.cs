using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TodoApi.Models;

public class User
{
    public int Id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public string? sub { get; set; }
}