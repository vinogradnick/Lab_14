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
        private static ArrayList history;

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

            AddHistory(result);

            return result;
        }

        static private void AddHistory(fakeData value)
        {
            history.Add(value);
        }

        static public void Reset()
        {
            if (history.Count > 0)
            {
                history.RemoveAt(history.Count - 1);
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
