using System.ComponentModel.DataAnnotations;

namespace Weather.API.Weather.Models.DTOS
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your password is less than {2} or more than {1}", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
