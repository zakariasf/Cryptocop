using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class LoginInputModel
    {
        [Required]
        public string Email { get; set; } //must be valid email adress

        [Required]
        public string Password { get; set; } //A minimum length of 8 characters

    }
}
