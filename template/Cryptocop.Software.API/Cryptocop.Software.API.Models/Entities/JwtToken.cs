using System;
using System.Collections.Generic;
using System.Text;
namespace Cryptocop.Software.API.Models.Entities
{
    public class JwtToken
    {
        public int Id { get; set; }
        public Boolean Blacklisted { get; set; }
    }
}
