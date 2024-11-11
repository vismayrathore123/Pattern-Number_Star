using System;

namespace Pattern18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
