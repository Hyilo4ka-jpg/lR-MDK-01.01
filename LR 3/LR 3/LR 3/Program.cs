using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{

    public class Program
    {
        static Order CreateOrder()
        {
            Order order = new Order();

            while (true)
            {
                Console.Write(
                    "Введите номер материала (0 — конец заказа): ");

                if (!int.TryParse(Console.ReadLine(), out int number) ||
                    number < 0 || number > 5)
                {
                    Console.WriteLine("Введите число от 0 до 5.");
                    continue;
                }

                if (number == 0)
                {
                    break;
                }

                Console.Write("Введите количество: ");

                if (!int.TryParse(Console.ReadLine(), out int quantity) ||
                    quantity <= 0)
                {
                    Console.WriteLine(
                        "Количество должно быть положительным целым числом.");
                    continue;
                }

                MaterialType type = (MaterialType)number;
                order.AddItem(type, quantity);
            }

            return order;
        }

        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            warehouse.PrintMaterials();

            Order order = CreateOrder();

            warehouse.ProcessOrder(order);

            warehouse.PrintRemains();

            Console.WriteLine();
            Console.WriteLine("Программа завершена.");
        }
    }

}
