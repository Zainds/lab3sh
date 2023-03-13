using System;

namespace lab3sh
{
    internal class Program
    {
        public static int square(int a, int b){
            return a*b;
        }
        public static void Main(string[] args)
        {
            
            int x, y;
            Console.WriteLine("Введите первую сторону пр-угольника");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону пр-угольника");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Площадь пр-угольника = " + square(x, y));
        }
    }
}