﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Models
{
    public class LoginViewModel
    {
        [Required]
        public String Username { get; set; }

        [Required]
        [UIHint("password")]
        public String Password { get; set; }
        [Required]
        [Display(Name ="Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
