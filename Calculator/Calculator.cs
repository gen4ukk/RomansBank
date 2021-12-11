using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public static decimal Do(decimal sum, int term, int percent)
        {
            //sum 200
            //percent 8
            //term 10
            //
            //200 / 100 * 8 = 16
            //16 / 12 * 10 = 13
            //200 + 13 = 213

            var percentSum = sum / 100 * percent;
            var termPercentSum = percentSum / 12 * term;

            return Math.Round(sum + termPercentSum, 2);
        }
    }
}
