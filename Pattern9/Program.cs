using System;

namespace Pattern9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
