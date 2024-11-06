using System;


namespace Pattern11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 5; i++)
            {
                int start = i + 1;
                for(int j=0;j<5; j++)
                {
                    Console.Write(start+j);
                }
            Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
