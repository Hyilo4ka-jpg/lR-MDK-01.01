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

            List<Product> products = new List<Product>();

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Name_;Price_;Quantity_;Type");
                writer.WriteLine("Cley Moment;350;200;Chancellery");
                writer.WriteLine("Colored pencils “Kalyaka‑Malyaka”;400;20;Artist");
                writer.WriteLine("Acrylic paints;600;150;Artist");
                writer.WriteLine("Colored paper;250;350;Chancellery");
                writer.WriteLine("A5 notebook;160;80;Chancellery");
                writer.WriteLine("Acrylic paints; 600; 150;Artist");
            }

            Console.WriteLine("Информация записана!(УРАААААААААА)");
            Console.ReadKey();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                
                Console.WriteLine("\nДанные из данного файла:");
                while ((line = reader.ReadLine()) != null)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');

                        string name = parts[0].Trim();
                        double price = double.Parse(parts[1].Trim());
                        int quantity = int.Parse(parts[2].Trim());
                        string type = parts[3].Trim();

                        Console.WriteLine($"Name_: {name}, Price_: {price}, Quantity_: {quantity}");

                        Product product;

                        if (type == "Chancellery")
                        {
                            product = new Chancellery();
                        }
                        else if (type == "Artist")
                        {
                            product = new Artist();
                        }
                        else
                        {
                            product = new Product();
                        }

                        product.SetName(name);
                        product.SetPrice(price);
                        product.SetQuantity(quantity);

                        products.Add(product);
                        
                    }
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
}
