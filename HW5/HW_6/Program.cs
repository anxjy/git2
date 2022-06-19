using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    internal class Program
    {
        static void Main()
        {
            int a = 22, b = 3;
            int c;
            c = a | b;
            Console.WriteLine(c);
            c = ~(~a & ~b);
            Console.WriteLine(c);

        }
    }
}
