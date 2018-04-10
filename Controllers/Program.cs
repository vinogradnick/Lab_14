using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc.Calculate("123", "234", "+").ret();
            Thread.Sleep(500);
            Calc.Calculate("123", "234", "-").ret();
            Thread.Sleep(500);
            Calc.Calculate("123", "234", "*").ret();
            Thread.Sleep(500);
            Calc.Calculate("123", "234", "/").ret();

            Calc.Reset().ret();
            Calc.Reset().ret();
            Calc.Reset().ret();
            Console.ReadLine();
        }
    }
}
