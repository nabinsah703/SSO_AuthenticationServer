using System.ComponentModel.DataAnnotations;

namespace AuthenticationServer.DTOs
{
    public class ValidateSSOTokenRequestDTO
    {
        [Required(ErrorMessage = "SSOToken is Required")]
        public string SSOToken { get; set; } = null!;
    }
}
