using System;
using System.Collections.Generic;
using System.Text;
namespace Cryptocop.Software.API.Models.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
