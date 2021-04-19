using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product { ProductName = "ütü", Id = 1, CatagoryId = 1 , UnitInStock=5, UnitPrice=300 };
            Product product2 = new Product {CatagoryId=2, UnitPrice=200, UnitInStock=3, Id=2, ProductName="çarşaf" };
            PruductManager pruductManager = new PruductManager();
            pruductManager.Add(product1);
        }
    }
}
