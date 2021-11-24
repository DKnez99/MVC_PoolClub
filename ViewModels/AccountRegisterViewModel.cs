using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Email address must be 3-100 characters long.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Password must be 6-30 characters long.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Confirm password must be 6-30 characters long.")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string ConfirmPassword { get; set; }

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
