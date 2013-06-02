using System;

public struct Complex
{
    public int real;
    public int imaginary;

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex com1, Complex com2)
    {
        return new Complex(com1.real + com2.real, com1.imaginary + com2.imaginary);
    }

    public override string ToString()
    {
        return ( String.Format("{0}" + "{1}i", real, imaginary ));
    }

    public static void Main(string[] a)
    {
        Complex com1 = new Complex(2, 3);
        Complex com2 = new Complex(4, 5);

        Complex sum = com1 + com2;

        Console.WriteLine("Sum of the two numbers {0}, {1}i", sum.real, sum.imaginary );
    }
}

