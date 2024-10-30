
using System;
namespace Pattern1
{
class Program
{
        static void Main()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
