using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLayer
{
   public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if(!context.User.Any())
            {
                //context.User.Add(new User())
            }
        }
    }
}
