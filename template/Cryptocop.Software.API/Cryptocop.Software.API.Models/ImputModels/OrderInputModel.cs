using System;
using System.ComponentModel.DataAnnotations;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class OrderInputModel
    {
        public int AddressId { get; set; }

        public int PaymentCardId { get; set; } 
    }
}
