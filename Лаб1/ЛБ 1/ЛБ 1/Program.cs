using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ_1
{
    internal class Program
    {
        public static double CalculateSquare()
        {
            Console.WriteLine("Введите стороны комнаты");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double Square = a * b * c; //square - эт площадь
            if (Square <= 0)
            {
                Console.WriteLine("Ошибка, площадь составила <= 0"); //ты серьезно думал что этог сработает...?
                CalculateSquare();
            }
            Console.WriteLine("Площадь стен: " + Square);
            return Square;
        }
        static void Main(string[] args)
        {
        }
    }
}
