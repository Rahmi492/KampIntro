using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();         
            product1.Explanation = "net ses";
            product1.ProductId = 1;
            product1.ProductName = "mikrofon";

            Product product2 = new Product();
            product2.ProductName = "kamera";
            product2.ProductId = 2;
            product2.Explanation = "net görüntü";

            Product product3 = new Product();
            product3.Explanation = "yüksek işlem";
            product3.ProductId = 3;
            product3.ProductName = "bilgisayar";
            Product[] Products = new Product[] {product3,product2,product1 };
            foreach (Product products in Products)
            {
                Console.WriteLine(products.ProductName + " = " + 
                    products.Explanation + "/ Ürün kodu = " + products.ProductId);
            }


           
        }
    }
}
