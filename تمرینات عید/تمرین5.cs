using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, h;
            a = int.Parse(Console.ReadLine());
            if (a <= 5)
                h = 0;
            else if (a <= 20)
                h = (a - 5) * 1000;
            else
                h = (20 - 5) * 1000 + (a - 20) * 5000;
            h = h + 1000;
            Console.WriteLine(h);
            Console.ReadLine();
        }
    }
}
