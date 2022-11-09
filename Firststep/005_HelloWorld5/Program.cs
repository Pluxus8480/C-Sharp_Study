using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_HelloWorld5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("지금 듣는 강의는 " + args[0]);
                Console.WriteLine( args[1] + " 좋아요!!");
            }
            else
            {
                Console.WriteLine("HelloWorld: args.Length = 0");
            }
            Console.ReadKey();
        }
    }
}
