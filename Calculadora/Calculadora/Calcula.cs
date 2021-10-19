using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calcula
    {
        public double DoOperation(double num1, double num2, string operation)
        {
            // Supported operations: *,/,+,-
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    Console.WriteLine("Introduce una operación valida");
                    return 0;

            }
        }

        public double CalculadoraMultiple(double [] nums, string [] sig) 
        {
            double resultado = nums[0];
            int contador = 0;

            if (nums.Length-1 == sig.Length)
            {
                for (int i = 1; nums.Length > i; i++, contador++)
                {

                    switch (sig[contador])
                    {
                        case "+":
                            resultado += nums[i];
                            break;
                        case "-":
                            resultado -= nums[i];
                            break;
                        case "*":
                            resultado = resultado * nums[i];
                            break;
                        case "/":
                            resultado = resultado / nums[i];
                            break;
                        default:
                            Console.WriteLine("No ingresaste una operacion valida");
                            return 0;
                    }


                }
                return resultado;
            }
            Console.WriteLine("No funciona asi.");
            return 0;
            
        }

    }
}
