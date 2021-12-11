using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class FormGetValues
    {
        public static decimal FillSum1()
        {
            bool isOk;
            decimal result;

            do
            {
                Console.WriteLine("Fill sum value");
                var sum = Console.ReadLine();

                isOk = decimal.TryParse(sum, out result);
                if (!isOk)
                {
                    Console.WriteLine($"your value has a wrong type - {sum}");
                    Console.WriteLine();
                }

            } while (!isOk);

            return result;
        }

        public static decimal FillSum2()
        {
            bool isOk;
            decimal result = 0;

            do
            {
                try
                {
                    Console.WriteLine("Fill sum value");
                    result = Convert.ToDecimal(Console.ReadLine());
                    isOk = true;
                }
                catch (Exception ex)
                {
                    isOk = false;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }

            } while (!isOk);

            return result;
        }
    }
}
