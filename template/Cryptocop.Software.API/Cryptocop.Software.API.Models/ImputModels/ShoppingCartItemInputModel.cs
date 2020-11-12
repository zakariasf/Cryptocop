using System;
using System.ComponentModel.DataAnnotations;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class ShoppingCartItemInputModel
    {
        [Required]
        public string ProductIdentifier { get; set; }

        [Required]
        public float Quantity { get; set; } //needs to be nullable and The range for this number is an include 0.01 to the float type maximum value
    }
}
