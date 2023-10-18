using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_64050122
{
    public class CustomerFactory
    {
        public static Customer CreateCustomer(string type)
        {
            if (type.Equals("Mountain", StringComparison.OrdinalIgnoreCase))
            {
                return new MountainCustomer();
            }
            else if (type.Equals("Delinquent", StringComparison.OrdinalIgnoreCase))
            {
                return new DelinquentCustomer();
            }
            else if (type.Equals("Regular", StringComparison.OrdinalIgnoreCase))
            {
                return new RegularCustomer();
            }
            return null;
        }
    }
}
