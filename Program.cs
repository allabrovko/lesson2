using System;


namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("результат задания 5: " + Test5().ToString());
            Console.WriteLine($"результат задания 7: {Test7()}");
            Console.WriteLine($"результат задания 17: {Test17()}");
            Console.WriteLine($"результат задания 8: {Test8()}");
            Console.WriteLine($"результат задания 21: {Test21()}");
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
        //задание 17
        private static double Test17()
        {
            double x = 1, y = 2;
            return (x * Math.Log(x) + (y / Math.Cos(x) - (x / 3)));
        }
        //задание 8
        private static double Test8()
        {
            double x = 2, y = 2;
            return Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x)) + Math.Cos(x - y);
        }
        //задание 21
        private static double Test21()
        {
            double x = 125;
            return 2 * 1 / Math.Tan(3 * x) - (Math.Log(Math.Cos(x) / Math.Log(1 + x * x)));
        }

    }
}