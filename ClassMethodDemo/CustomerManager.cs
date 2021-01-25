using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer's ID added ---> " +customer.Id );
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Number has been deleted --> "+ customer.CustomerNumber);
        }
    }
}
