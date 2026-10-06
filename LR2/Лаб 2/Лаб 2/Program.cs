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
        static void Main(string[] args)
        {
        }
    }
}
