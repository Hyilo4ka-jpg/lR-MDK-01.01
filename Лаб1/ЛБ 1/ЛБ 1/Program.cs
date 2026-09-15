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
        public static void RecommendedAmount(double amountPaint)
        {
            if (amountPaint <= 1000) // amoutPaint - it is количество краски
            {
                Console.WriteLine("Рекомендуемая банка 1л");
            }
            else if (amountPaint <= 2000)
            {
                Console.WriteLine("Рекомендуемая банка 2л");
            }
            else if (amountPaint <= 5000)
            {
                Console.WriteLine("Рекомендуемая банка 5л");
            }
            else if (amountPaint <= 10000)
            {
                Console.WriteLine("Рекомендуемая банка 10л");
            }
        }
        static void Main(string[] args)
        {
            double square = CalculateSquare(); //выполняется функция и приравнивается значиние (>0<)
            double squareForPainting = CalculateSquareForPainting(square);
            double amountPaint = CalculateAmountPaint(squareForPainting);// вызывается функция "канкулятор кол-во краски", в неё подставляется значение площади под покраску
            RecommendedAmount(amountPaint); // вызыв функции "рекомендуемое количество" и подставляется значение кол-во краски
        }
    }
}
