using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCalculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

    
        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 + num2;

            textResultado.Text = resultado.ToString();
           
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 - num2;

            textResultado.Text = resultado.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 * num2;

            textResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);

            resultado = num1 / num2;

            textResultado.Text = resultado.ToString();
        }
    }
}
