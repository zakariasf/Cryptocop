using System;
using System.ComponentModel.DataAnnotations;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class PaymentCardInputModel
    {
        [Required]
        public string CardholderName { get; set; } //A minimum length of 3 characters

        [Required]
        public string CardNumber { get; set; } //Must be a valid credit card number

        public int Month { get; set; } //The range for this number is an inclusive 1 to 12

        public int Year { get; set; } //The range for this number is an inclusive 0 to 99

    }
}
