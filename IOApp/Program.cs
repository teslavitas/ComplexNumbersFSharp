using ComplexNumbers;
using System;

namespace IOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new ComplexNumber(12, 13);
            Console.WriteLine(ComplexOperations.Stringify(x));
        }
    }
}
