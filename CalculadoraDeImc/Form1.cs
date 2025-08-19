using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblPeso_Click(object sender, EventArgs e)
        {

        }

        private void bxbCalcular_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão preenchidos:
            if(txbAltura.Text == "")
            {
                MessageBox.Show("Digite a altura.");
            }else if(txbPeso.Text == "")
            {
                MessageBox.Show("Digite o Peso.");
            }
            else
            {
               double peso = double.Parse(txbPeso.Text);
                double altura = double.Parse(txbAltura.Text);
                double imc = peso / (altura * altura);
                txbIMC.Text = imc.ToString("F2"); // duas casas decimais

                // Classificação
                if (imc < 18.5)
                    lblResultado.Text = "Abaixo do peso";
                else if (imc >= 18.5 && imc <= 24.9)
                    lblResultado.Text = "Peso ideal (parabéns)";
                else if (imc >= 25 && imc <= 29.9)
                    lblResultado.Text = "Levemente acima do peso";
                else if (imc >= 30 && imc <= 34.9)
                    lblResultado.Text = "Obesidade grau I";
                else if (imc >= 35 && imc <= 39.9)
                    lblResultado.Text = "Obesidade grau II (severa)";
                else
                    lblResultado.Text = "Obesidade III (mórbida)";
            }
            
            

        }
    }
}
