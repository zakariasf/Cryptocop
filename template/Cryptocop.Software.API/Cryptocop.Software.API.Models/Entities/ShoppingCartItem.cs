using System;
using System.Collections.Generic;
using System.Text;
namespace Cryptocop.Software.API.Models.Entities
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public string ProductIdentifier { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation properties
        public ShoppingCart ShoppingCart { get; set; }
    }
}
