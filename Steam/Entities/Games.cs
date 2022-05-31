using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Steam
{
    public class Games
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Descriprion { get; set; }
        public double OldPrice { get; set; }
        public String UrlPhoto { get; set; }
        public String UrlGame { get; set; }
        public int Discount { get; set; }
        public String Date { get; set; }
        public double NewPrice { get; set; }
    }
}
