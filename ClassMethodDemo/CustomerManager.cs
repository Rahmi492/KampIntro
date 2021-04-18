using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void add(Customer customer)
        {
            Console.WriteLine(" added --> " + customer.CustomerName);
        }
        public void delete(Customer customer)
        {
            Console.WriteLine("deleted---> "+ customer.CustomerName);
        }
        public void list(Customer customer)
        {
            Console.WriteLine("listed----> " + customer.CustomerName);
        }
    }
}
