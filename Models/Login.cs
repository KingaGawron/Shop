﻿using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
