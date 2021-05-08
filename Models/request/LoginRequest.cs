using System.ComponentModel.DataAnnotations;

namespace auth_service_dotnet.Models.Users
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}