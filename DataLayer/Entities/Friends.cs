using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer
{
    [Keyless]
    public class Friends
    {
        [ForeignKey(nameof(User))]
        public int User1Id{ get; set; }
        [ForeignKey(nameof(User))]
        public int User2Id { get; set; }
        public int State { get; set; }
    }
}
