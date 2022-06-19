using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            int k = 0;
            for (int i=0; i < 32; i++)
            {
                if ((a & 0x1) == 1) { k++; }
                a = a >> 1;
            }
            if (k == 1) Console.WriteLine("This number is a power of two");
            else Console.WriteLine("This number is not a power of two");
        }
    }
}
