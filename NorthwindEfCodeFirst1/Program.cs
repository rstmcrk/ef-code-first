using NorthwindEfCodeFirst1.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirst1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var northwindContext= new Northwind2Context())
            {
                foreach (var customer in northwindContext.Customers)
                {
                    Console.WriteLine("Customer Name: {0}", customer.ContactName);
                } 
            }
            Console.ReadKey();
        }
    }
}
