using System.ComponentModel.DataAnnotations;

namespace OneClickJS.Data.Models
{
    public class UserInfo
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserLastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
