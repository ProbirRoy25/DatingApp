using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(25,MinimumLength=4,ErrorMessage="Password length morethen equal 4 character!")]
        public string Password { get; set; }
    }
}