using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_64050122
{
    public class MountainCustomer : Customer
    {
        public override string CreateMail()
        {
            return "Mountain Customer";
        }
    }
}
