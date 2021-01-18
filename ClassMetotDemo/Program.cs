using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Yasin",
                Surname = "Çınar",
                HesapNo = "19971905"
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Muhsin",
                Surname = "Çınar",
                HesapNo = "19951905"
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Asaf",
                Surname = "Çınar",
                HesapNo = "20201905"
            };
            Customer customer4 = new Customer()
            {
                Id = 4,
                Name = "Metin",
                Surname = "Çınar",
                HesapNo = "19721905"
            };

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer3);
            

            customerManager.Delete(customer1);
            customerManager.Delete(customer3);
            


            customerManager.List(customers);
            
        }
    }
}
