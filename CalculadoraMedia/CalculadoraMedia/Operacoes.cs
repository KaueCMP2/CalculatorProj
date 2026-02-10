using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMedia
{
    public class Operacoes
    {
        public void adicao(TextBox text ,int numero1, int numero2)
        {
            text.Clear();
            text.Text = (numero1 + numero2).ToString();
        }

        public void subtracao(TextBox text, int numero1, int numero2)
        {
            text.Clear();
            text.Text = (numero1 - numero2).ToString();
        }

        public void multiplicacao(TextBox text, int numero1, int numero2)
        {
            text.Clear();
            text.Text = (numero1 * numero2).ToString();
        }

        public void divisao(TextBox text, int numero1, int numero2)
        {
            text.Clear();
            text.Text = (numero1 / numero2).ToString();
        }

        public void porcentagem(TextBox text, int numero1, int numero2)
        {
            text.Clear();
            text.Text = (numero1 % numero2).ToString();
        }
    }
}
