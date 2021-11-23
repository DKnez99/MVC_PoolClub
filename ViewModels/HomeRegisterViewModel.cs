using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class HomeRegisterViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Not a valid E-Mail address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Must be between 3 and 100 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Must be between 6 and 30 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Must be between 6 and 30 characters")]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Must be up to 30 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "Must be up to 30 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Phone(ErrorMessage = "Not a valid phone number")]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "Must be 7-30 characters long")]
        public string PhoneNumber { get; set; }
    }
}
