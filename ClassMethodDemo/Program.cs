using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer0 = new Customer();
            customer0.CustomerId = 1;
            customer0.CustomerName = "rahmi";
            customer0.CustomerLastName = "koç";

            Customer customer1 = new Customer();
            customer1.CustomerId = 2;
            customer1.CustomerName = "ismail";
            customer1.CustomerLastName = "koç";

            Customer[] customers = {customer0,customer1 };

            foreach (var Customers in customers)
            {
                Console.WriteLine(Customers.CustomerName + " " + Customers.CustomerLastName + " / " + Customers.CustomerId);
            };

            CustomerManager customerManager = new CustomerManager();

             customerManager.add(customer0);
             customerManager.add(customer1);
            customerManager.delete(customer0);
            customerManager.delete(customer1);
            customerManager.list(customer1);
            customerManager.list(customer0);
               
            
        }
    }
}
