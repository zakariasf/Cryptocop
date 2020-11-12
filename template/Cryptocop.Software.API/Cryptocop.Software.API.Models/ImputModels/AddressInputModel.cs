using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Cryptocop.Software.API.Models.ImputModels
{
    public class AddressInputModel
    {
        [Required]
        public string StreetName { get; set; }

        [Required]
        public string HouseNumber { get; set; }
        
        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public DateTime City { get; set; }
    }
}
