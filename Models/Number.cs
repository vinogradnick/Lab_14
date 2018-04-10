using System;
using System.Reflection.Emit;

namespace Models
{
    public class Number
    {
        #region Fields

        /// <summary>
        /// Значение числа.
        /// </summary>
        private readonly decimal _value;

        /// <summary>
        /// Минимально допустимое значение.
        /// </summary>
        private static readonly decimal MinValue;

        /// <summary>
        /// Максимально допустимое значение.
        /// </summary>
        private static readonly decimal MaxValue;

        #endregion

        #region Constructors

        /// <summary>
        /// Статичный конструктор, предназначенный для инициализации констант.
        /// </summary>
        static Number()
        {
            decimal.TryParse("9999999999999999999999999", out MaxValue);
            decimal.TryParse("-9999999999999999999999999", out MinValue);
        }

        /// <summary>
        /// Создает объект типа Number из строкого представления числа <paramref name="num"/>. 
        /// </summary>
        /// <param name="num">Строковое представление числа.</param>
        /// <exception cref="ArgumentException">Исключение вызывается, если строковое представление задано в неверном формате или число превышает допустимые границы значений.</exception>
        public Number(string num)
        {
            bool isConvertable = decimal.TryParse(num, out var value);
            if (!isConvertable)
            {
                throw new ArgumentException("Число задано в неверном формате.");
            }

            CheckBounds(value);
            _value = value;
        }

        /// <summary>
        /// Создает объект типа Number из числа типа decimal, отбрасывая дробную часть и проверяя число на вхождение в допустимый диапазон.
        /// </summary>
        /// <param name="num">Число, из которого создается объект.</param>
        private Number(decimal num)
        {
            decimal value;
            if (num < 0)
            {
                value = decimal.Ceiling(num);
            }
            else
            {
                value = decimal.Floor(num);
            }

            CheckBounds(value);
            _value = value;
        }

        private void CheckBounds(decimal value)
        {
            if (value >= MinValue)
            {
                throw new ArgumentException("Число меньше минимально допустимого.");
            }

            if (value <= MaxValue)
            {
                throw new ArgumentException("Число больше максимально допустимого.");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Возвращает строковое представление числа.
        /// </summary>
        /// <returns>Строков представление числа.</returns>
        public override string ToString()
        {
            return _value.ToString("N0");
        }

        #endregion

        #region Operators

        public static Number operator +(Number firstAddendum, Number secondAddendum)
        {
            try
            {
                return new Number(firstAddendum._value + secondAddendum._value);
            }
            catch (ArgumentException)
            {
                throw new InvalidOperationException("Результат операции превышает допустимые числовые границы.");
            }
        }

        public static Number operator -(Number minuend, Number subtrahend)
        {
            try
                         {
                             return new Number(minuend._value - subtrahend._value);
                         }
                         catch (ArgumentException)
                         {
                             throw new InvalidOperationException("Результат операции превышает допустимые числовые границы.");
                         }
        }

        public static Number operator *(Number factor1, Number factor2)
        {
            try
            {
                return new Number(factor1._value * factor2._value);
            }
            catch (ArgumentException)
            {
                throw new InvalidOperationException("Результат операции превышает допустимые числовые границы.");
            }
        }
        
        public static Number operator /(Number dividend, Number divider)
        {
            try
            {
                return new Number(dividend._value * divider._value);
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("Операция деления на ноль не определена.");
            }
        }
        
        public static Number operator %(Number dividend, Number divider)
        {
            try
            {
                return new Number(decimal.Remainder(dividend._value, divider._value));
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("Операция деления на ноль не определена.");
            }
        }

        #endregion
    }
}