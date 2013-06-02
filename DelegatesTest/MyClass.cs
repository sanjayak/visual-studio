using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    delegate void MyDelegate( string s );
    class MyClass
    {
        public static void Hello(string s)
        {
            Console.WriteLine(" Hello, {0}!", s);
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine(" GoodBye, {0}!", s );
        }

        public static void main( string [] arg)
        {
            MyDelegate a, b, c, d;

            a = new MyDelegate(Hello);
            b = new MyDelegate(Goodbye);

            c = a + b;

            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invoking delegate d:");
            d("D");

        }
    }
}
