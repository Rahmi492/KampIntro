using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "tavuk dürüm";
            product1.Id = 1;
            product1.explanation = "hatay dürümü";
            product1.Price = 10;
            
            Product product2 = new Product();
            product2.ProductName = "lahmacun";
            product2.Id = 2;
;            product2.explanation = "çıtır çıtır";
            product2.Price = 7;

            Product[] Pruducts = new Product[] {product1,product2 };
            foreach (Product products in Pruducts)
            {
                Console.WriteLine(products.ProductName + "  " + products.explanation );
            }
            Console.WriteLine("----------Methods------------");
            //instance-örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Add(product1);
            sepetmanager.Add(product2);
            sepetmanager.Add2(12,1,"güzel","elma",7);

        }
    }
}
