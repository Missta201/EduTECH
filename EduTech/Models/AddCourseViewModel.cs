using System.ComponentModel.DataAnnotations;

namespace EduTech.Models
{
    public class AddCourseViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tên khóa học")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    
}
