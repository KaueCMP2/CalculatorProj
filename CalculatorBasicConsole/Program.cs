using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using CalculatorBasicConsole;

namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraRun();

        static void CalculadoraRun()
        {
            //* Instanciando a classe operacoes para facilitar...
            var op = new Operacoes();

            //* Abertura...
            Console.WriteLine($"Digite um numero para iniciarmos as operações");
            string numeroDig1 = Console.ReadLine();
            int numero1 = 0;

            //? Primeira grande verificação para saber se um numero foi digitado...
            if (string.IsNullOrWhiteSpace(numeroDig1) || !int.TryParse(numeroDig1, out numero1))
            {
                Console.WriteLine($"Puts, O conteudo digitado: {Console.ReadLine()} não é um valor aceito... tente novamente");
                return;
            }

            //* Pedido de seleção de um operador matematico, para realizarmos a operação...
            Console.WriteLine($"Isso ai! Agora selecione um operador matematico para prosseguirmos \n as opções são (+), (-), (x), (/), (%) ou (r)");
            string operador = Console.ReadLine();

            //? Segunda grande verificação, que verifica se um operador realmente foi selecionado...
            if (string.IsNullOrEmpty(operador) || operador != "+" && operador != "-" && operador != "x"
                                               && operador != "X" && operador != "%" && operador != "r")
            {
                Console.WriteLine($"O operador é obrigatorio para prosseguirmos");
                Console.WriteLine("Digite novamente");
                return;
            }

            //? Terceira grande se o operador é r de raiz quadrada...
            if (operador == "r")
            {
                op.RaizQuadrada(numero1);
                return;
            }

            Console.WriteLine($"Isso ai! Agora selecione um segundo numero para prosseguirmos");
            string numeroDig2 = Console.ReadLine();
            int numero2 = 0;

            //? Quarta grande verificação para verificar se um numero foi digitado
            if (string.IsNullOrWhiteSpace(numeroDig2) || !int.TryParse(numeroDig2, out numero2))
            {
                Console.WriteLine($"Puts, O conteudo digitado: {numero2} não é um valor aceito... tente novamente");
            }
            if (operador == "+")
            {
                op.Adicao(numero1, numero2);
            }
            if (operador == "-")
            {
                op.Subtracao(numero1, numero2);
            }
            if (operador == "x" || operador == "X" || operador == "*")
            {
                op.Multiplicacao(numero1, numero2);
            }
            if (operador == "/")
            {
                op.Divisao(numero1, numero2);
            }
            if (operador == "%")
            {
                op.Porcentagem(numero1, numero2);
            }


            Console.WriteLine("Pressione r para reiniciar ou q para sair!!!");
            if (Console.ReadLine() == "r")
            {
                Console.Clear();
                CalculadoraRun();
            }
            else
            {
                return;
            }
        }
    }
}
