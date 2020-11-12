using System;
using System.ComponentModel.DataAnnotations;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class RegisterInputModel
    {
        [Required]
        public string Email { get; set; } //must be valid email address

        [Required]
        public string FullName { get; set; } //min 3 char

        [Required]
        public string Password { get; set; } //min length of 8

        [Required]
        public string PasswordConfirmation { get; set; } // min length 8 must be the same as above


    }
}
