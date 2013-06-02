using System;
using TraceFunctions;

public class TraceTest
{
    public static void Main(string[] a)
    {
        Trace.Message("Main Starting");

        if (a.Length == 0)
        {
            Console.WriteLine("No arguments are specified");
        }
        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Args[{0}] is [{1}] ", i, a[i]);
            }
        }

        Trace.Message("Main Ending");
    }
}