using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace LibrariesTest
{
    class FunctionClient
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Function Client");

            if (args.Length == 0)
            {
                Console.WriteLine("Usage: FunctionTest ... ");
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                int num = Int32.Parse(args[i]);
                Console.WriteLine(
                   "The Digit Count for String [{0}] is [{1}]",
                   args[i],
                    // Invoke the NumberOfDigits static method in the
                    // DigitCount class:
                   DigitCounter.NumberOfDigits(args[i]));
                Console.WriteLine(
                   "The Factorial for [{0}] is [{1}]",
                    num,
                    // Invoke the Calc static method in the Factorial class:
                    Factorial.Calc(num));
            }
        } 
    }
}
