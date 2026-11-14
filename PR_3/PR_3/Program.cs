using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "popo.txt";

            List<Product> products = CSVLoader.LoadProducts(path);

                Console.WriteLine("\nДанные из данного файла:");
                foreach (Product product in products)
                {
                        Console.WriteLine($"Name_: {product.GetName()}, " +
                            $"Price_: {product.GetPrice ()}, " +
                            $"Quantity_: {product.GetQuantity()}");

                }
                Console.ReadKey();
                Console.WriteLine("");
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
