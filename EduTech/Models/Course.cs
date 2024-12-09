using System.ComponentModel.DataAnnotations;

namespace EduTech.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0 phải nhập}")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
