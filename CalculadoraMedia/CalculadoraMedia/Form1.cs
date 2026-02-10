using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            textBox1.ReadOnly = true;
        }

        // Numeros...        
        private void button1_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button9);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            verificarCompostos(textBox1, button11);
        }

        // Equals...
        private void button15_Click(object sender, EventArgs e)
        {
            string[] composto = textBox1.Text.Split(' ');
            if (composto.Length > 0 && composto.Length <= 3)
            {
                Operacoes op = new Operacoes();

                int numero1 = Convert.ToInt32(composto[0]);
                int numero2 = Convert.ToInt32(composto[2]);
                if (composto[1] == "-")
                {
                    op.subtracao(textBox1, numero1, numero2);
                }

                else if (composto[1] == "+")
                {
                    op.adicao(textBox1, numero1, numero2);
                }

                else if (composto[1] == "x")
                {
                    op.multiplicacao(textBox1, numero1, numero2);
                }

                else if (composto[1] == "÷")
                {
                    op.divisao(textBox1, numero1, numero2);
                }

                else if (composto[1] == "%")
                {
                    op.porcentagem(textBox1, numero1, numero2);
                }
            }
        }

        // Operadores numericos...
        private void button13_Click(object sender, EventArgs e)
        {
            verificarCompostosOperadores(textBox1, button13);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            verificarCompostosOperadores(textBox1, button12);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            verificarCompostosOperadores(textBox1, button10);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            verificarCompostosOperadores(textBox1, button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            verificarCompostosOperadores(textBox1, button17);
        }

        // Clear...
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        public bool verificarCompostos(TextBox textBox, Button button)
        {
            string[] composto = textBox.Text.Split();
            if (composto.Length > 3)
            {
                textBox.Text = textBox.Text;
                return false;
            }

            textBox1.Text += button.Text;
            return true;
        }

        public bool verificarCompostosOperadores(TextBox text, Button button)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return false;
            }

            string[] composto = text.Text.Split();
            if (composto.Length > 2)
            {
                text.Text = text.Text;
                return false;
            }

            textBox1.Text += " " + button.Text + " ";
            return true;
        }

    }
}
