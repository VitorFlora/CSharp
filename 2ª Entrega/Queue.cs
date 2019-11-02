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
    public partial class Queue : Form
    {
        Queue<int> fila = new Queue<int>();

        public Queue()
        {
            InitializeComponent();
        }
        
        int cont = 0;

        public void add()
        {
            fila.Enqueue(cont);
            cont++;
        }
        
        public void atualizar()
        {
            dgv.Rows.Clear();
            foreach (int i in fila)
            {
                dgv.Rows.Add();
                dgv[0, dgv.Rows.Count -1].Value = i;
            }
        }
        
        private void btadd_Click(object sender, EventArgs e)
        {
            add();
            atualizar();           
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            if (fila.Count != 0)
            {
                fila.Dequeue();
                atualizar();
                cont--;
            }
            else
                MessageBox.Show("A fila está vazia","Opa",0);
        }
    }
}
