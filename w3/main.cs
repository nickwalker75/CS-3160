using System;
using CustomerNS;

namespace MainNS
{
    class App
    {
        static void Main(string[] args)
        {
            // create customer array
            Customer[] = customers;
            customers = CreateCustomers();

            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }
        static Customer[] CreateCustomers(){}
    }//class
}//namespace