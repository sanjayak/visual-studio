using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Factorial
    {
        public static int Calc( int n )
        {
            return ((n <= 1) ? 1 : n * Calc(n - 1));
        }
    }
}
