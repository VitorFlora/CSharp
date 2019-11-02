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
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            if (text1.Text == string.Empty && text2.Text == string.Empty)
            {
                MessageBox.Show("Preencha com algum número!");
            }
            else
            {
                int x = int.Parse(text1.Text);
                int y = int.Parse(text2.Text);
                res.Text = (x + y).ToString();
            }       
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            calcular(); 
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
