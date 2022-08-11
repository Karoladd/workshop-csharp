using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula220822
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            lbl_msg.Text = txt_nome.Text + " parabéns!";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_num1.Text = "";
            txt_num2.Text = "";
            lbl_msg.Text = "";
            txt_nome.Focus();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_num1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_num2_Click(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            double soma = num1 + num2;
            lbl_msg.Text = soma.ToString();
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_subt_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            if (num1 >= num2)
            {
                double subt = num1 - num2;
                lbl_msg.Text = subt.ToString();
            }
            else {
                lbl_msg.Text = "Número 1 é menor que Número 2. Tente novamente.";
            }
                
            
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            double mult = num1 * num2;
            lbl_msg.Text = mult.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            if (num2==0)
            {
                lbl_msg.Text = "Não é possível dividir por 0. Tente novamente.";
            }
            else
            {
                double div = num1 / num2;
                lbl_msg.Text = div.ToString();
            }

        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            double pot = Math.Pow(num1,num2);
            lbl_msg.Text = pot.ToString();
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            double raiz = Math.Pow(num1, 1/num2);
            lbl_msg.Text = raiz.ToString();
        }
    }
}
