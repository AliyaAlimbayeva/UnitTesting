using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    public class OddEven
    {
        public static string GetDefOddEven(int number)
        {
            return StringOfNumber(number);
        }

        private static string StringOfNumber(int number)
        {
            if (IsEvenNumber(number))
            {
                return "Even";
            }
            else if (!IsPrime(number))
            {
                return "Odd";
            }
            else
            {
                return Convert.ToString(number);
            }
        }

        public static string PrintNumbers(int start, int end)
        {
            string resStr = string.Empty;
            if (start < 1 || end > 100)
            {
                throw new ArgumentException();
            }
            for (int number = start; number <= end; number++)
                resStr += ' ' + StringOfNumber(number);
            return resStr;
        }

        private static bool IsEvenNumber(int number)
        {
            return number > 2 && number % 2 == 0;
        }

        private static bool IsOddNumber(int number)
        {
            return (number > 2 && number % 2 != 0);
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
