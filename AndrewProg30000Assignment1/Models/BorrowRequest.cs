using System.ComponentModel.DataAnnotations;

namespace AndrewProg30000Assignment1.Models
{
    public class BorrowRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone must be in the format xxx-xxx-xxxx (e.g. 905-922-2222)")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select your role")]
        public Role? Role { get; set; }

        [Required(ErrorMessage = "Please select the equipment type")]
        public EquipmentType? EquipmentType { get; set; }

        [Required(ErrorMessage = "Please enter the request details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please enter the duration in days")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than zero")]
        public int? DurationDays { get; set; }
    }
}