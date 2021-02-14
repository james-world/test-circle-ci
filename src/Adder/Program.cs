using System;

namespace Adder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            var calculator = new Calculator();
            var (a, b) = parser.Parse(args);
            var result = calculator.Add(a, b);
            Console.WriteLine(result);
        }
    }
}
