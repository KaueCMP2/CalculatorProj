using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorBasicConsole
{
    public class Operacoes
    {
        public double Adicao(double Numero1, double Numero2)
        {
            Console.WriteLine($"{Numero1 + Numero2}");
            return Numero1 + Numero2;
        }
        public double Subtracao(double Numero1, double Numero2)
        {
            Console.WriteLine($"{Numero1 - Numero2}");
            return Numero1 - Numero2;
        }
        public double Multiplicacao(double Numero1, double Numero2)
        {
            Console.WriteLine($"{Numero1 * Numero2}");
            return Numero1 * Numero2;
        }
        public double Divisao(double Numero1, double Numero2)
        {
            Console.WriteLine($"{ Numero1 / Numero2}");
            return Numero1 / Numero2;
        }
        public double Porcentagem(double Numero1, double Numero2)
        {            
            Console.WriteLine($"{Numero1 % Numero2}");
            return Numero1 % Numero2;
        }
        public double RaizQuadrada(double Numero1)
        {
            Console.WriteLine($"{Math.Sqrt(Numero1)}");
            return Math.Sqrt(Numero1);
        }
    }
}