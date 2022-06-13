using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Models
{
    public class RegViewModel
    {
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String RepeatPassword { get; set; }
        [Required]
        public bool Agreement { get; set; }
    }
}
