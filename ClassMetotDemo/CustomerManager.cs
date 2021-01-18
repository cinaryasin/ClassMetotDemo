using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("ID : " +customer.Id );
            Console.WriteLine("                ");
            Console.WriteLine("Name : " +customer.Name);
            Console.WriteLine("                ");
            Console.WriteLine("Surname : " +customer.Surname);
            Console.WriteLine("                ");
            Console.WriteLine("Hesap No : " + customer.HesapNo);
            Console.WriteLine("                ");
            Console.WriteLine("Added Customer");
            Console.WriteLine("                ");

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("ID : " + customer.Id);
            Console.WriteLine("                ");
            Console.WriteLine("Name : " + customer.Name);
            Console.WriteLine("                ");
            Console.WriteLine("Surname : " + customer.Surname);
            Console.WriteLine("                ");
            Console.WriteLine("Hesap No : " + customer.HesapNo);
            Console.WriteLine("                ");
            Console.WriteLine("Deleted Customer");
            Console.WriteLine("                ");
        }
        public void List(Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("ID : " + customers.Id);
                Console.WriteLine("Name : " + customers.Name);
                Console.WriteLine("Surname : " + customers.Surname);
                Console.WriteLine("Hesap No : " + customers.HesapNo);
                Console.WriteLine("                ");
                Console.WriteLine("Listed Customer");
                Console.WriteLine("                ");

            }
        }
    }
}
