using System;
using System.IO;

namespace Open_Lab_01._4
{
    class GFG
    {
        public static void Main()
        {
            int Base;
            Console.WriteLine("Enter the base value: ");
            Base = Convert.ToInt32(Console.ReadLine());

            int Height;
            Console.WriteLine("Enter the height value: ");
            Height = Convert.ToInt32(Console.ReadLine());

            int result2 = TriArea(Base, Height);
            Console.WriteLine($"TriArea value is {result2}");
        }
        private static int TriArea(int Base, int Height)
        {
            int result = (Base * Height) / 2;
            return result;
        }
    }
}
