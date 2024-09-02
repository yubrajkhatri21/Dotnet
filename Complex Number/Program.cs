using System;

class ComplexNumber
{
    public double Real { get; }
    public double Imaginary { get; }

 public ComplexNumber(double real, double imaginary) => (Real, Imaginary) = (real, imaginary);

    public static ComplexNumber operator *(ComplexNumber c, int n) =>
        new ComplexNumber(c.Real * n, c.Imaginary * n);

    public override string ToString() => $"{Real} + {Imaginary}i";
}

class Program
{
    static void Main() => Console.WriteLine(new ComplexNumber(1, 2) * 2);
}
