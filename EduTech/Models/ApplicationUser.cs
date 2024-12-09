using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EduTech.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? Name { get; set; }
    }
}
