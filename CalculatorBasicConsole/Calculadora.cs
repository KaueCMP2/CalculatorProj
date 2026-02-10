using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorBasicConsole
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set;}
        public string Usuario { get; set; }

        //* Construtor de calculadora
        public Calculadora(double _Numero1, double _Numero2, double _Resultado)
        {
            Numero1 = _Numero1;
            Numero2 = _Numero2;
            Resultado = _Resultado;
        }

        public double Adicionar(double Numero1, double Numero2, double Resultado)
        {
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"{Resultado}");
            return Resultado;
        }
        public double Subtrair(double Numero1, double Numero2, double Resultado)
        {
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"{Resultado}");
            return Resultado;
        }
        public double Multiplicar(double Numero1, double Numero2, double Resultado)
        {
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"{Resultado}");
            return Resultado;
        }
        public double Dividir(double Numero1, double Numero2, double Resultado)
        {
            Resultado = Numero1 / Numero2;
            Console.WriteLine($"{Resultado}");
            return Resultado;
        }
        public double RaizQuadrada(double Numero1, double Resultado)
        {
            Resultado = Math.Sqrt(Numero1);
            Console.WriteLine($"{Resultado}");
            return Resultado;
        }
        public bool verificarNumero(double? Numero1, double? Numero2)
        {
            int numero1Validado;
            if(int.TryParse(Numero1, out numero1Validado));
        }
    }
}