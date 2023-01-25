using Microsoft.AspNetCore.Identity;

namespace Weather.API.Weather.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
