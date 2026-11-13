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
            string path = "popo.txt";

                using (StreamWriter writer = new StreamWriter(path))
                {
                writer.WriteLine("Name_;Price_;Quantity_");
                writer.WriteLine("Cley Moment;350;200");
                writer.WriteLine("Colored pencils “Kalyaka‑Malyaka”;400;20");
                writer.WriteLine("Acrylic paints;600;150");
                writer.WriteLine("Colored paper;250;350");
                writer.WriteLine("A5 notebook;160;80");
                writer.WriteLine("Acrylic paints; 600; 150");
                }

            Console.WriteLine("Информация записана!(УРАААААААААА)");
            Console.ReadKey();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                Console.WriteLine("\nДанные из данного файла:");
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    Console.WriteLine($"Name_: {parts[0]}, Price_: {parts[1]}, Quantity_: {parts[2]}");
                }

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

