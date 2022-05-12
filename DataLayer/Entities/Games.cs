using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    class Games
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Descriprion { get; set; }
        public double Price { get; set; }
        public String UrlPhoto { get; set; }
    }
}
