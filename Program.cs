using System;


namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("результат задания 5: " + Test5());
            Console.WriteLine("результат задания 7: " + Test7());
        }


        //задание 5
        private static double Test5()
        {
            double x = 1, y = 2;
            return (3 + Math.Pow(Math.E, y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x)));
        }

        //задание 7
        private static double Test7()
        {
            double x = 1, y = 2;
            return Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + (x * x) / 4))));
        }
    }
}
