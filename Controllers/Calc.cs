using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controllers
{
    class Calc
    {
        static public void Calculate(string inputNumber1, string inputNumber2, string command)
        {
            CheckNumber(inputNumber1, "Первый аргумент");
            CheckNumber(inputNumber2, "Второй аргумент");

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
                default:
                    throw new Exception("Недопустимая команда: " + command[0]);
            }
        }

        static private void CheckNumber(string value, string valueName)
        {
            Regex regex = new Regex(@"[^\d]");
            Match regresult = regex.Match(value);

            if (value.Length > 25)
            {
                throw new Exception(valueName + ": Значение превышает 25 цифр");
            }
            if (regresult.Success)
            {
                throw new Exception(valueName + ": Встречен недопустимый символ -> " + regresult.Value);
            }
        }
    }
}
