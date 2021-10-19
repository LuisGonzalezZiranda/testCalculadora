using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new Calcula();
            var result = op.DoOperation(5, 5, "*");
            Console.WriteLine(result);

            var exem = new Calcula();
            double[] num = { 5, 10, 1, };
            string[] sig = { "*", "+", };
            var complete = exem.CalculadoraMultiple(num, sig);
            Console.WriteLine(complete);
        }
    }
}
