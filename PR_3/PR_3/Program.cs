using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product();
            product1.SetName("Клей Момент");
            product1.SetPrice(350);
            product1.SetQuantity(200);
            products.Add(product1);


            Chancellery product2 = new Chancellery();
            product2.SetName("Цветные карандаши Каляка-Маляка");
            product2.SetPrice(400);
            product2.SetQuantity(20);
            products.Add(product2);

            Chancellery product3 = new Chancellery();
            product3.SetName("Краски акриловые");
            product3.SetPrice(600);
            product3.SetQuantity(150);
            products.Add(product3);

            Chancellery product4 = new Chancellery();
            product4.SetName("Бумага цветная");
            product4.SetPrice(250);
            product4.SetQuantity(350);
            products.Add(product4);
        }
    }
}
