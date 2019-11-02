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
    public partial class Media : Form
    {
        int a;
        int b;
        int c;
        int d;
        int e;
        double result;

        public Media()
        {
            InitializeComponent();
        }

        public void variaveis()
        {
            if (text1.Text != "" && text2.Text != "" && text3.Text != "" && text4.Text != "" && text5.Text != "")
            {
                a = int.Parse(text1.Text);
                b = int.Parse(text2.Text);
                c = int.Parse(text3.Text);
                d = int.Parse(text4.Text);
                e = int.Parse(text5.Text);
            }
            else
            {
                MessageBox.Show("Insira um número", "Atenção", 0);
            }
        }

        private void cal_media_Click(object sender, EventArgs ev)
        {
            variaveis();
            if (a != 0 && b != 0 && c != 0 && d != 0 && e != 0)
            {
                result = ((a + b + c + d + e) / 5);
            }
            res.Text = Math.Round(result,1).ToString();
        }
    }
}
