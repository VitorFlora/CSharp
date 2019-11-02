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
    public partial class Laco : Form
    {
        public Laco()
        {
            InitializeComponent();
        }

        public new void Move()
        {
            for (int i = 0; i <= listBox1.Items.Count + 99; i++)
            {
                if (listBox1.SelectedItem != null)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//adiciona
        {
            if (box1.Text != "")
            {
                listBox1.Items.Add(box1.Text);
                box1.Text = "";
                box1.Focus();
            }
            else
                MessageBox.Show("Insira algo", "Opa", 0);
        }
        private void button2_Click_1(object sender, EventArgs e)//move 1
        {
            Move();
        }

        private void button3_Click_1(object sender, EventArgs e)//move todos
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
            Move();
        }
    }
}
