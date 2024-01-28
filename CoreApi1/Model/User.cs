using System.ComponentModel.DataAnnotations;

namespace CoreApi1.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be at most 50 characters long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email ID is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number. It must be 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Skillset is required")]
        public string SkillSet { get; set; }

        public string Hobby { get; set; }
    }

}
