using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MediaP : Form
    {
        public MediaP()
        {
            InitializeComponent();
        }
        
        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Calcular")
            {
                double n1 = double.Parse(ac1.Text);
                double n2 = double.Parse(ac2.Text);
                double n3 = double.Parse(tio.Text);
                double number4 = double.Parse(ar.Text);
                double equiAc1 = n1 * 0.1;
                double equiAc2 = n2 * 0.2;
                double equiTio = n3 * 0.2;
                double equiAr = number4 * 0.5;
                double result = equiAc1 + equiAc2 + equiTio + equiAr;
                resultado.Text = result.ToString();

                if (result >= 7)
                {
                    txtExame1.Visible = true;
                    txtExame1.Text = "Aprovado!";
                    button1.Visible = false;
                    button2.Visible = true;
                }
                else
                {
                    txtExame1.Visible = true;
                    lblExame.Visible = true;
                    exame.Visible = true;
                    txtExame1.Text = "Sujeito a Exame!";
                    button1.Text = "Calcular pós exame";
                }
            }
            else if (button1.Text == "Calcular pós exame")
            {
                resultado.Text = ((double.Parse(resultado.Text) + double.Parse(exame.Text)) / 2).ToString();
                if (double.Parse(resultado.Text) >= 5)
                {
                    txtExame1.Text = "Aprovado após Exame";
                    button1.Text = "Zerar Tudo";
                }
                else
                {
                    txtExame1.Text = "Reprovado!";
                    button1.Text = "Zerar Tudo";
                }
            }
            else if (button1.Text == "Zerar Tudo")
            {
                ac1.Text = "";
                ac2.Text = "";
                tio.Text = "";
                ar.Text = "";
                resultado.Text = "";
                exame.Text = "";
                exame.Visible = false;
                txtExame1.Visible = false;
                lblExame.Visible = false;
                button1.Text = "Calcular";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ac1.Text = "";
            ac2.Text = "";
            tio.Text = "";
            ar.Text = "";
            resultado.Text = "";
            exame.Text = "";
            button2.Visible = false;
            button1.Visible = true;
            exame.Visible = false;
            txtExame1.Visible = false;
            lblExame.Visible = false;
        }
    }
}
