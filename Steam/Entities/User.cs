
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Steam
{
    [Keyless]
    public class User:IdentityUser
    {
        
        [Required]
        [DefaultValue(0.0)]
        public double Balance { get; set; }
        public String Photo { get; set; }
        public String Description { get; set; }

    }
}
