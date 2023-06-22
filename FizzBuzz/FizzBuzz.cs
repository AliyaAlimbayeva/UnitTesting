using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string PrintNumbers(int start, int end) 
        {
            string resStr = string.Empty;
            if (start < 1 || end > 100)
            {
                throw new ArgumentException();
            }
            for (int i = start; i <= end; i++)
            {
                resStr += ' ' + IsFizzBuzz(i);
            }
            return resStr;
        }

        public static string IsFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return Convert.ToString(number);
            }

        }
    }
}
