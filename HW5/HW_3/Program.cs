using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    internal class Program
    {
        static void Main()
        {
            int x = 5, y = 10, z = 15;
            x += y >> x++ * z;
            Console.WriteLine(x);
            z = ++x & y * 5;
            Console.WriteLine(z);
            y /= x + 5 | z;
            Console.WriteLine(y);
            z = x++ & y * 5;
            Console.WriteLine(z);
            x = y << x++ ^ z;
            Console.WriteLine(x);
        }
    }
}
