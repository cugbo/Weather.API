using System.ComponentModel.DataAnnotations;

namespace Weather.API.Weather.Models.DTOS
{
    public class RegisterUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
