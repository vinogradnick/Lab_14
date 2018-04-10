using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controllers
{
    class fakeData
    {
        private int a;
        public fakeData()
        {
            Random dice = new Random();
            a = dice.Next(0, 10000);
        }

        public static fakeData operator +(fakeData a, fakeData b)
        {
            return new fakeData();
        }

        public static fakeData operator -(fakeData a, fakeData b)
        {
            return new fakeData();
        }

        public static fakeData operator *(fakeData a, fakeData b)
        {
            return new fakeData();
        }

        public static fakeData operator / (fakeData a, fakeData b)
        {
            return new fakeData();
        }

        public void ret()
        {
            Console.WriteLine(a);
        }

    }

    class Calc
    {
        private static List<fakeData> history = new List<fakeData>();

        static public fakeData Calculate(string inputNumber1, string inputNumber2, string command)
        {
            CheckNumber(inputNumber1, "Первый аргумент");
            CheckNumber(inputNumber2, "Второй аргумент");

            fakeData value1 = new fakeData(),
                     value2 = new fakeData(),
                     result;
            

            switch (command[0])
            {
                case '/':
                    result = value1 / value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                default:
                    throw new Exception("Недопустимая команда: " + command[0]);
            }

            history.Add(result);

            return result;
        }

        static public fakeData Reset()
        {
            if (history.Count() > 1)
            {
                history.RemoveAt(history.Count - 1);

                return history[history.Count - 1];
            }else
            {
                throw new Exception("Больше нет записей с историей");
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
