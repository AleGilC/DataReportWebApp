using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDTO
    {
         [Required(ErrorMessage = "Your {0} is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Your {0} is required")]
        public string Password { get; set; }
    }
}