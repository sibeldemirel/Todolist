using System.ComponentModel.DataAnnotations;

namespace Todolist.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
