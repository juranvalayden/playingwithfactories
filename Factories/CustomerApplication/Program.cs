using System;
using System.Collections.Generic;
using Model.Factories;
using Model.Interfaces;

namespace CustomerApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customerTypes = new List<string>
            {
                "Normal", "No Tax", "Holiday"
            };

            var customers = new List<ICustomer>();

            foreach (var customerType in customerTypes)
            {
                customers.Add(SimpleFactory.CreateRetailCustomer(customerType));
            }

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.TotalBill());
            }

            Console.ReadLine();
        }
    }
}
