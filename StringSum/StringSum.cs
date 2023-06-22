using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public class StringSum
    {
        public static string Sum(string num1, string num2)
        {
            int n1, n2;
            if ((!float.TryParse(num1, out _)) || (!float.TryParse(num2, out _)))
            {
                throw new ArgumentException();
            }

            int changedNum1 = Convert.ToInt32(ZeroInsteadNotNatural(num1));
            int changedNum2 = Convert.ToInt32(ZeroInsteadNotNatural(num2));

            return Convert.ToString(changedNum1 + changedNum2);
        }
        private static string ZeroInsteadNotNatural(string num)
        {
            if (!int.TryParse(num, out int n)) return "0";
            return (n < 0) ? "0" : num;
        }
    }
}
