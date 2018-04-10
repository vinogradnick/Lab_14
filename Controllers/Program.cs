using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Controllers
{
    class Program
    {
        static void r(string[] b)
        {
            string result = "[ ";

            if (b.Length >= 1)
            {
                result += b[0];
            }
            for (int i = 1; i < b.Length; i++)
            {
                result += ", " + b[i];

            }
            result += " ]";
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            r(Calc.Calculate("123", "234", "+"));
            Thread.Sleep(500);
            r(Calc.Calculate("123", "234", "-"));
            Thread.Sleep(500);
            r(Calc.Calculate("123", "234", "*"));
            Thread.Sleep(500);
            r(Calc.Calculate("123", "234", "/"));
            Thread.Sleep(500);

            Console.WriteLine();

            r(Calc.Reset());
            r(Calc.Reset());
            r(Calc.Reset());
            Console.ReadLine();
        }
    }
}
