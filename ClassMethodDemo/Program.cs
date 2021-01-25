using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = "11111111111";
            customer1.Name = "Yeliz";
            customer1.Surname = "Akın";
            customer1.Job = "Teacher";
            customer1.Age = 32;
            customer1.CustomerNumber = "22222";

            Customer customer2 = new Customer();
            customer2.Id = "33333333333";
            customer2.Name = "Aylin";
            customer2.Surname = "Tepe";
            customer2.Job = "Computer Engineer";
            customer2.Age = 28;
            customer2.CustomerNumber = "44444";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname);
                Console.WriteLine(customer.Job);
                Console.WriteLine(customer.CustomerNumber);
                Console.WriteLine("-------------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete(customer2);

        }
    }
}
