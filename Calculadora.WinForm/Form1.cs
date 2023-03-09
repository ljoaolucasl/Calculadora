using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumero(e);
        }

        private void button1_Click(object sender, EventArgs e) //1
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if(textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "1";
            }
            else
            {
                textBox_Resultado.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e) //2
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "2";
            }
            else
            {
                textBox_Resultado.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e) //3
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "3";
            }
            else
            {
                textBox_Resultado.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e) //4
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "4";
            }
            else
            {
                textBox_Resultado.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e) //5
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "5";
            }
            else
            {
                textBox_Resultado.Text = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e) //6
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "6";
            }
            else
            {
                textBox_Resultado.Text = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e) //7
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "7";
            }
            else
            {
                textBox_Resultado.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e) //8
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "8";
            }
            else
            {
                textBox_Resultado.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e) //9
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "9";
            }
            else
            {
                textBox_Resultado.Text = "9";
            }
        }

        private void button0_Click(object sender, EventArgs e) //0
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
            }

            if (textBox_Resultado.Text != "0")
            {
                textBox_Resultado.Text += "0";
            }
            else
            {
                textBox_Resultado.Text = "0";
            }
        }

        private void buttonC_Click(object sender, EventArgs e) //Limpar
        {
            label_dividirAlerta.Visible = false;
            label_primeiroNumero.Text = "";
            label_segundoNumero.Text = "";
            label_sinal.Text = "";
            textBox_Resultado.Text = "";
            confirma = false;
            virgula = true;
        }

        private void button13_Click(object sender, EventArgs e) //Sinal de Somar
        {
            if (textBox_Resultado.Text != "" && label_primeiroNumero.Text == "")
            {
                label_primeiroNumero.Text = textBox_Resultado.Text;
                textBox_Resultado.Text = "";
                virgula = true;
            }
            if (!confirma) { label_sinal.Text = "+"; } 
        }

        private void button14_Click(object sender, EventArgs e) //Sinal de Subtrair
        {
            if (textBox_Resultado.Text != "" && label_primeiroNumero.Text == "")
            {
                label_primeiroNumero.Text = textBox_Resultado.Text;
                textBox_Resultado.Text = "";
                virgula = true;
            }
            if (!confirma) { label_sinal.Text = "-"; }
        }

        private void button15_Click(object sender, EventArgs e) //Sinal de Multiplicação
        {
            if (textBox_Resultado.Text != "" && label_primeiroNumero.Text == "")
            {
                label_primeiroNumero.Text = textBox_Resultado.Text;
                textBox_Resultado.Text = "";
                virgula = true;
            }
            if (!confirma) { label_sinal.Text = "X"; }

        }

        private void button16_Click(object sender, EventArgs e) //Sinal de Divisão
        {
            if (textBox_Resultado.Text != "" && label_primeiroNumero.Text == "")
            {
                label_primeiroNumero.Text = textBox_Resultado.Text;
                textBox_Resultado.Text = "";
                virgula = true;
            }
            if (!confirma) { label_sinal.Text = "÷"; }
        }

        bool confirma = false;
        bool virgula = true;

        private void button17_Click(object sender, EventArgs e) //Calcular Resultado
        {
            if (label_primeiroNumero.Text != "" && label_sinal.Text != "")
            {
                decimal resultado = 0;

                if(!confirma)
                {
                    label_segundoNumero.Text = textBox_Resultado.Text;
                }
                else
                {
                    return;
                }

                if(label_segundoNumero.Text != "")
                {

                    if(label_sinal.Text == "+") { resultado = Convert.ToDecimal(label_primeiroNumero.Text) + Convert.ToDecimal(label_segundoNumero.Text); }

                    else if (label_sinal.Text == "-") { resultado = Convert.ToDecimal(label_primeiroNumero.Text) - Convert.ToDecimal(label_segundoNumero.Text); }

                    else if (label_sinal.Text == "X") { resultado = Convert.ToDecimal(label_primeiroNumero.Text) * Convert.ToDecimal(label_segundoNumero.Text); }

                    else if (label_sinal.Text == "÷") 
                    { 
                        if(label_segundoNumero.Text != "0")
                        {
                            resultado = Convert.ToDecimal(label_primeiroNumero.Text) / Convert.ToDecimal(label_segundoNumero.Text);
                        } 
                        else
                        {
                            label_dividirAlerta.Visible = true;
                            textBox_Resultado.Text = "";
                            confirma = true;
                            return;
                        }
                    }

                    textBox_Resultado.Text = Convert.ToString(Math.Round(resultado, 2));

                    comboBox_historico.Items.AddRange(new object[] { label_primeiroNumero.Text + " " + label_sinal.Text + " " + label_segundoNumero.Text + " = " + textBox_Resultado.Text });

                    confirma = true;
                }
            }
        }

        private void button_mudaSinal_Click(object sender, EventArgs e) //Mudar Sinal entre +/-
        {
            if (!confirma)
            {
                decimal numero = Convert.ToDecimal(textBox_Resultado.Text) * -1;
                textBox_Resultado.Text = Convert.ToString(numero);
            }
        }

        private void button_virgula_Click(object sender, EventArgs e) //Vírgula
        {
            label_dividirAlerta.Visible = false;

            if (confirma)
            {
                textBox_Resultado.Text = "";
                label_primeiroNumero.Text = "";
                label_segundoNumero.Text = "";
                label_sinal.Text = "";
                confirma = false;
                virgula = true;
            }

            if (textBox_Resultado.Text != "" && virgula)
            {
                textBox_Resultado.Text += ",";
                virgula = false;
            }
        }
    }
}
