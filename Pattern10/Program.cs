//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pattern10
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("6");
//            for(int i = 1; i <= 6; i++)
//            {
//                for(int j=1; j <= i; j++)
//                {
//                    Console.Write(j);

//                }
//                Console.WriteLine();
//            }
//            Console.ReadLine();
//        }
//    }
//}



using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("6");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
                
            }
            Console.Write("6");
            Console.WriteLine();
        }
        Console.ReadLine(); 
    }
}
