using System;

namespace MyProject

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mod1");
            Console.WriteLine("Mod2");
            Console.WriteLine("Mod3");
            int[] fgh = {1, 2, 3, 4, 5, 6 };
            Console.WriteLine(CalculateAverage(fgh));
            

        }
        public static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
    }
}