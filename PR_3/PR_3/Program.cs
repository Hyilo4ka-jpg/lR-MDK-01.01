using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            Artist product5 = new Artist();
            product5.SetName("Простой карандаш Berlingo");
            product5.SetPrice(50);
            product5.SetQuantity(120);
            products.Add(product5);

            Artist product6 = new Artist();
            product6.SetName("Блокнот А5");
            product6.SetPrice(160);
            product6.SetQuantity(80);
            products.Add(product6);

            Console.WriteLine("Отчёт по товарам: \n");

            foreach (Product product in products)
            {
                Console.WriteLine(
                  product.GetName() +
                  "| Цена: " + product.GetPrice() +
                  "| Кол-во: " + product.GetQuantity() +
                  "| Стоимость: " + product.GetCost() +
                  "| Скидка: " + product.GetDiscount() + "%" +
                  "| Сумма скидки: " + product.GetDiscountSum() +
                  "| Итого: " + product.GetFinalCost()
                  );

            }

            Console.ReadKey();
        }
    }
}
