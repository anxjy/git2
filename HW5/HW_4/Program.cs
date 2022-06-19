using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    internal class Program
    {
        static void Main()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            if (s > 0 && s < 5) Console.WriteLine("10%");
            if (s >= 5 && s < 10) Console.WriteLine("15%");
            if (s >= 10 && s < 15) Console.WriteLine("25%");
            if (s >= 15 && s < 20) Console.WriteLine("35%");
            if (s >= 20 && s < 25) Console.WriteLine("45%");
            if (s >= 25) Console.WriteLine("50%");

        }
    }
}
