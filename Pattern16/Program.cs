using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern16
{
    class Program
    {
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("12345");
            }
            else
            {
                Console.WriteLine("*****");
            }
        }
            Console.ReadLine();
    }
}
}

