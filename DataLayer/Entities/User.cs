using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public double Balance { get; set; }
    }
}
