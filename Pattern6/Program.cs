using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 5; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine    ();
        }
    }
}
