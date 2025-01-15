using System.ComponentModel.DataAnnotations;

namespace Todolist.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required string Status { get; set; }
    } 
}
