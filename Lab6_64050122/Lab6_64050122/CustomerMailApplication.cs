﻿using System;

namespace Lab6_64050122
{

    class CustomerMailApplication
    {
        static void Main(string[] args)
        {
            Customer cust = GetCustomerTypeFromUser();
            string mail = null;
            if (cust != null)
            {
                mail = GenerateMail(cust);
                Console.WriteLine(mail);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        static string GenerateMail(Customer cust)
        {
            return cust.CreateMail();
        }

        static Customer GetCustomerTypeFromUser()
        {
            Customer cust = null;
            Console.Write("Please choose customer type 1. Regular, 2. Mountain, 3. Delinquent: ");
            int type = Convert.ToInt32(Console.ReadLine());
            switch (type)
            {
                case 1:
                    cust = CustomerFactory.CreateCustomer("Regular");
                    break;
                case 2:
                    cust = CustomerFactory.CreateCustomer("Mountain");
                    break;
                case 3:
                    cust = CustomerFactory.CreateCustomer("Delinquent");
                    break;
            }
            return cust;
        }
    }
}
