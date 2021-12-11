using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sum = FormGetValues.FillSum1();

            var res1 = Calculator.Do(sum, 12, 7);

            var res2 = Calculator.Do(200, 6, 3);

            Console.WriteLine($"first result={res1},  second result={res2}");
        }
    }
}
