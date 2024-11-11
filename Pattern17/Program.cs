using System;
namespace Pattern17
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i ; j++)
                {
                    Console.Write(i);
                }
                for (int k = i ; k <= 5; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}