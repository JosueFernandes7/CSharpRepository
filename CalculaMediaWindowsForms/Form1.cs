using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Calcular
        private void button1_Click(object sender, EventArgs e)
        {
            float soma, media, valor;
            soma = 0;

            foreach(Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }

                media = soma / 4;
                this.Controls["label6"].Text = media.ToString();
            }
        }

        // Limpar
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control controle in this.Controls)
            {
                if(controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
            }
            this.Controls["label6"].Text = "...";
        }
    }
}
