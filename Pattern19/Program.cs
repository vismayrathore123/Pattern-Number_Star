using System;

namespace Pattern19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=7;i>=1; i--)
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
