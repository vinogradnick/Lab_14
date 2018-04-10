using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Calc
    {
        static public void Calculate(string inputNumber1, string inputNumber2, string command)
        {
            if (inputNumber1.Length > 25)
            {
                throw new Exception("Значение первого аргумента превышает 25 цифр");
            }
            if (inputNumber2.Length > 25)
            {
                throw new Exception("Значение второго аргумента превышает 25 цифр");
            }
            switch (command[0])
            {
                case '/':
                    break;
                case '*':
                    break;
                case '+':
                    break;
                case '-':
                    break;
            }
        }

        void CheckNumber(string value, string valueName)
        {
            if (value.Length > 25)
            {
                throw new Exception(valueName + ": Значение превышает 25 цифр");
            }
            if ()
            {

            }
        }
    }
}
