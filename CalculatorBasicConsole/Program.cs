using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Digite um numero para iniciarmos as operações");
        string numeroDig1 = Console.ReadLine();
        int numero1;
        if (string.IsNullOrWhiteSpace(numeroDig1) || !int.TryParse(numeroDig1, out numero1))
        {
            Console.WriteLine($"Puts, O conteudo digitado: {Console.ReadLine()} não é um valor aceito... tente novamente");
            return;
        }

        Console.WriteLine($"Isso ai! Agora selecione um operador matematico para prosseguirmos \n as opções são (+), (-), (x), (/), (%) ou (r)");
        string operador = Console.ReadLine();
        if (string.IsNullOrEmpty(operador))
        {
            Console.WriteLine($"O operador é obrigatorio para prosseguirmos");
            Console.WriteLine("Digite novamente");
            return;
        }

        if (operador == "r")
        {
            Console.WriteLine($"Isso ai! Digite um segundo numero para iniciarmos as operações");
            resultado = Math.Sqrt(numero1);
            Console.WriteLine($"{resultado}");
            return;
        }

        string numeroDig2 = Console.ReadLine();
        int numero2;
        if (string.IsNullOrWhiteSpace(numeroDig2) || !int.TryParse(numeroDig2, out numero2))
        {
            Console.WriteLine($"Puts, O conteudo digitado: {numero1} não é um valor aceito... tente novamente");
            // Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            // Environment.Exit(0);
            return;
        }
        if (operador == "+")
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"{resultado}");
        }
        else if (operador == "-")
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"{resultado}");
        }
        else if (operador == "x" || operador == "X" || operador == "*")
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"{resultado}");
        }
        else if (operador == "/")
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"{resultado}");
        }
        else if (operador == "%")
        {
            resultado = numero1 % numero2;
            Console.WriteLine($"{resultado}");
        }
    }
}
