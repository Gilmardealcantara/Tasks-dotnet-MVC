using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
  public class TaskItem
  {
    [Key]
    public int Id { get; set; }

    [StringLength(200)] 
    public string OwnerId { get; set; }
    
    [Display(Name = "Task Complete")]
    public bool IsComplete { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50)]
    public string Name { get; set; }
    
    [Display(Name = "Conclusion Date")]
    public DateTimeOffset? ConclusionDate { get; set; }
  }
}