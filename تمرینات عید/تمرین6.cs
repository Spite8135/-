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
            int a, b;
            a = 0;
                b = int.Parse(Console.ReadLine());
            if (b < 10)
                a = b;
            else if (b < 100)
                a = b / 10;
            else if (b < 1000)
                a = b / 100;
            else if (b < 10000)
                a = b / 1000;
            else if (b < 100000)
                a = b / 10000;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
