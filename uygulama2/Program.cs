using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int x = 20;
            int y = 13;
            int z = 42;


            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);
            Console.WriteLine(23 <= 23 && 45 != 18);
            Console.WriteLine(x > y && z == y && z < x);
            Console.WriteLine(z > x && y < x);
            Console.WriteLine(x!=z || y<=z);
            
        }
    }
}
