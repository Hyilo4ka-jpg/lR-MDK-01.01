using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_2
{
    public struct Material
    {
        public string Name;
        public int Price;
        public int Quantity;

        public Material(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
    internal class Program
    {
        static Material[] CreateWarehouse()
        {
            return new Material[]
            {
            new Material("цемент", 650, 30),
            new Material("кирпич", 250, 40),
            new Material("профнастил", 1450, 20),
            new Material("гипсокартон", 420, 25),
            new Material("гвозди", 90, 35)
            };
        }
        static void PrintWarehouse(Material[] warehouse)
        {
            Console.WriteLine("Склад стройматериалов:");
            Console.WriteLine();

            for (int i = 0; i < warehouse.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {warehouse[i].Name} — " + $"{warehouse[i].Price} руб., " + $"{warehouse[i].Quantity} шт.");
            }
            Console.WriteLine();
        }
        static int[] CreateOrder(Material[] warehouse)
        {
            int[] order = new int[warehouse.Length];

            int number = -1;

            while (number != 0)
            {
                Console.Write("Введите номер материала (0 — конец заказа): ");
                number = Convert.ToInt32(Console.ReadLine());

                while (number < 0 || number > 5)
                {
                    Console.WriteLine("Введите число от 0 до 5.");
                    Console.Write("Введите номер материала: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }

                if (number == 0)
                {
                    break;
                }

                Console.Write("Введите количество: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                while (quantity < 0)
                {
                    Console.WriteLine("Количество не может быть меньше нуля.");
                    Console.Write("Введите количество: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                }

                order[number - 1] += quantity;
            }
            for (int i = 0; i < warehouse.Length; i++)
            {
                if (order[i] > warehouse[i].Quantity)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Недостаточно материала: {warehouse[i].Name}.");
                    return null;
                }
            }
            int cost = 0;
            for (int i = 0; i < warehouse.Length; i++)
            {
                cost += warehouse[i].Price * order[i]; warehouse[i].Quantity -= order[i];
            }
            Console.WriteLine(); Console.WriteLine($"Стоимость заказа: {cost} руб.");
            return order;
        }

        static void Main(string[] args)
        {
        }
    }
}
