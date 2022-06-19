using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    internal class Program
    {
        static void Main()
        {
            //1 вариант
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("The number is even");
            else Console.WriteLine("The number is odd");
            //2 вариант
            int b = Convert.ToInt32(Console.ReadLine());
            
            if ((b & 0x1) == 0) Console.WriteLine("The number is even");
            else Console.WriteLine("The number is odd");
        }
    }
}
