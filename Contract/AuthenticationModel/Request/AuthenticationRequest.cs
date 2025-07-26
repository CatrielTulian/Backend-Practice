using System.ComponentModel.DataAnnotations;

namespace Contract.AuthenticationModel.Request
{
    public class AuthenticationRequest
    {
        [Required]
        public string User { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
