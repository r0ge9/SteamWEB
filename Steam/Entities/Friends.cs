using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Steam
{
    [Keyless]
    public class Friends
    {
        [ForeignKey(nameof(User))]
        public string User1Id{ get; set; }
        [ForeignKey(nameof(User))]
        public string User2Id { get; set; }
        public int State { get; set; }
    }
}
