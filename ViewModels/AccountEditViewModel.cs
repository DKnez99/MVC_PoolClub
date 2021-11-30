using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class AccountEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Email address must be 3-100 characters long.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Password must be 6-30 characters long.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "New password must be 6-30 characters long.")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Confirm new password must be 6-30 characters long.")]
        [Compare("NewPassword", ErrorMessage = "New passwords must match.")]
        public string ConfirmNewPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        [StringLength(30, ErrorMessage = "First name must be up to 30 characters long.")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        [StringLength(30, ErrorMessage = "Last name must be up to 30 characters long.")]
        public string LastName { get; set; }

        [Required]
        [Phone(ErrorMessage = "Phone number is not valid.")]
        [Display(Name = "Phone number")]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Phone number must be 7-30 characters long.")]
        public string PhoneNumber { get; set; }
    }
}
