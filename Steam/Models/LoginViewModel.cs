using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Логин")]
        public String Username { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name ="Пароль")]
        public String Password { get; set; }

        [Display(Name ="Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
