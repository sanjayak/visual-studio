using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConversionTest
{
    class Test
    {
        public static void Main( string[] a )
        {
            RomanNumeral romanNumeral;

            romanNumeral = 10;

            Console.WriteLine(romanNumeral);

            Console.WriteLine( (int)romanNumeral);

            Console.WriteLine((short)romanNumeral);

        }
    }

    struct RomanNumeral
    {
        int number;
        
        public RomanNumeral( int value )
        {
            this.number = value;
        }

        public static implicit operator RomanNumeral( int value )
        {
            return new RomanNumeral( value );
        }

        public static explicit operator int( RomanNumeral value )
        {
            return value.number;
        }

        public static implicit operator string(RomanNumeral value )
        {
            return "Conversion not yet implemented";
        }
    }
}
