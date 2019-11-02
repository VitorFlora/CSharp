using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Calculator : Form
    {
        int x;
        int y;
        int z;

        public Calculator()
        {
            InitializeComponent();
        }

        public virtual void limpar()
        {
            res.Text = "";
            rest.Text = "";
            text1.Text = "";
            text2.Text = "";
            text1.Focus();
        }

        private void variaveis()
        {
            if (text1.Text != "" && text2.Text != "")
            {
                x = int.Parse(text1.Text);
                y = int.Parse(text2.Text);
                z = x % y;
            }
            else
            {
                MessageBox.Show("Insira um número", "Atenção", 0);
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            variaveis();
            res.Text = (x + y).ToString();
            Console.WriteLine(x);
            rest.Text = "";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            variaveis();
            res.Text = (x - y).ToString();
            rest.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            variaveis();
            res.Text = (x * y).ToString();
            rest.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            variaveis();
            res.Text = (x / y).ToString();
            rest.Text = z.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            limpar();
        }
        
    }
}
