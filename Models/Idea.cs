using System;
using System.ComponentModel.DataAnnotations;

namespace Idea_a_roma.Models
{
  public class Idea
  {
    public int Id { get; set; }
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public string TagLine { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
  }
}