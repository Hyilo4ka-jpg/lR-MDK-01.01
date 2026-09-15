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
        public static double CalculateSquareForPainting(double square)
        {
            Console.WriteLine("Введите количество окон и дверей");
            double squareWindow = 1.68;
            double squareDoor = 1.6;
            int countWindows = Convert.ToInt32(Console.ReadLine());
            int countDoors = Convert.ToInt32(Console.ReadLine());
            if (countWindows < 0 || countDoors < 0)
            {
                Console.WriteLine("Ошибка, количество окон или дверей <=0");
                CalculateSquareForPainting(square);
            }
            double squareForPainting = square - (squareDoor * countDoors) - (squareWindow * countWindows);
            Console.WriteLine("Площадь под покраску: " + squareForPainting);
            return squareForPainting;
        }
        public static double CalculateAmountPaint(double squareForPainting)
        {
            double amount = squareForPainting * 150;
            Console.WriteLine("Необходимое количество краски: " + amount);
            return amount;
        }
        static void Main(string[] args)
        {
        }
    }
}
