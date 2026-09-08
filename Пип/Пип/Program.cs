using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пип
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число z:");
            int z = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число x:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число c:");
            int c = int.Parse(Console.ReadLine());

            int max = z;

            if (x > max) max = x;
            if (c > max) max = c;

        }
    }
}
