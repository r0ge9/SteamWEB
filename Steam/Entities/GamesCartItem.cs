using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Models
{
    public class GamesCartItem
    {
        public int Id { get; set; }
        public Games Game { get; set; }
        public double Price { get; set; }
        public string GamesCartId { get; set; }
    }
}
