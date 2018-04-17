using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class HistoryElement
    {
        string number1, number2, result, command;
        public HistoryElement(string number1, string number2, string result, string command)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.result = result;
            this.command = command;
        }

        public string[] ToStringArray()
        {
            string[] convented = { number1, number2, result, command };
            return convented;
        }
    }


    class fakeData
    {
        private int a;
        public fakeData(string b = "abc")
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

        public static fakeData operator %(fakeData a, fakeData b)
        {
            return new fakeData();
        }

        public override string ToString()
        {
            return a.ToString();
        }

        public void ret()
        {
            Console.WriteLine(a);
        }

    }

   public class Calc
    {
        public static List<HistoryElement> history = new List<HistoryElement>();

        public static string[] Calculate(string inputNumber1, string inputNumber2, string command)
        {
            CheckNumber(inputNumber1, "Первый аргумент");
            CheckNumber(inputNumber2, "Второй аргумент");

            Number value1 = new Number(inputNumber1),
                     value2 = new Number(inputNumber2),
                     result;
            

            switch (command[0])
            {
                case '%':
                    result = value1 % value2;
                    break;
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

            HistoryElement newEntry = new HistoryElement(inputNumber1, inputNumber2, result.ToString(), command);
            history.Add(newEntry);

            return newEntry.ToStringArray();
        }

        public static string[] Reset()
        {
            if (history.Count > 1)
            {
                history.RemoveAt(history.Count - 1);

                return history[history.Count - 1].ToStringArray();
            }else
            {
                throw new Exception("Больше нет записей с историей");
            }
        }

        private static void CheckNumber(string value, string valueName)
        {
            Regex regex = new Regex(@"[^\d]");
            Match regresult = regex.Match(value);

            if (value.Length > 25)
            {
                throw new Exception(valueName + ": Значение превышает 25 цифр");
            }
           

        }
    }
}
