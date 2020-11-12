﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptocop.Software.API.Models.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int TokenId { get; set; }

    }
}
