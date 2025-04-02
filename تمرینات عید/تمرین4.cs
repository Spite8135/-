using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                i = a;
                a = b;
                b = i;
            }
            if (a > c)
            {
                i = a;
                a = c;
                c = i;
            }
            if (b > c)
            {
                i = b;
                b = c;
                c = i;
            }
            Console.WriteLine(a + "" + b + "" + c);
                Console.ReadLine();
            
        }
    }
}
