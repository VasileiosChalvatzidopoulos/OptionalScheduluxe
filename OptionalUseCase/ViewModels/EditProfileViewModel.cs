using System.ComponentModel.DataAnnotations;

namespace OptionalUseCase.ViewModels
{
    // View Model for the Edit Profile
    public class EditProfileViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Country { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
