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
    public partial class Pilha : Form
    {
        public Pilha()
        {
            InitializeComponent();
        }

        Stack<string> pilha = new Stack<string>();


        public void Add()
        {
            string nome = txt1.Text;
            pilha.Push(nome);                      
        }
        
        public void Atualiza()
        {
            dgv.Rows.Clear();
            foreach (string i in pilha)
            {
                dgv.Rows.Add(i);
            }
            txt1.Focus();
            txt1.Text = "";
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Add();
            Atualiza();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            pilha.Pop();
            Atualiza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string next = pilha.First();
            MessageBox.Show(next);
            Atualiza();
        }
    }
}
