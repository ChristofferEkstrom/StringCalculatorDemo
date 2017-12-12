using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorDemo
{
    public class Calculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public int Add(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return 0;

            int sum = 0;
            if (expression.Contains(","))
            {
                string[] digits = expression.Split(',');
                foreach(string digit in digits)
                {
                    sum += int.Parse(digit);
                }
                //sum = int.Parse(digits[0]) + int.Parse(digits[1]);

            }
            else
            {
                sum = int.Parse(expression);
            }
            return sum;

            //return int.Parse(expression);
        }
    }
}

