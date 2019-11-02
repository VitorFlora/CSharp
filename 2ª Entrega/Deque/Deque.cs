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
    public partial class Deque : Form
    {
        List<Deck> listDeque = new List<Deck>();

        public Deque()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {             
            Deck deque = new Deck();
            deque.dado = txtDado.Text;
            if (listDeque.Count == 0)
            {
                deque.direita = 0;
                deque.esquerda = 0;
            }
            else
            {
                deque.esquerda = listDeque.Count - 1;
                deque.direita = 0;
                listDeque[listDeque.Count - 1].direita = listDeque.Count;
                listDeque[0].esquerda = listDeque.Count;
            }
            listDeque.Add(deque);
            atualiza();
            txtDado.Focus();
            txtDado.Text = "";            
        }

        public void atualizaRelacoes()
        {
            Boolean primeiro = true;
            int count = 0;
            foreach (Deck de in listDeque)
            {
                if (listDeque.Count == 1)
                {
                    de.direita = 0;
                    de.esquerda = 0;
                }
                else if (primeiro)
                {
                    de.direita = count + 1;
                    de.esquerda = listDeque.Count() - 1;
                    primeiro = false;
                }
                else if (count == listDeque.Count - 1)
                {
                    de.direita = 0;
                    de.esquerda = count - 1;
                }
                else
                {
                    de.direita = count + 1;
                    de.esquerda = count - 1;
                }
                count++;
            }
            atualiza();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listDeque.Count > 0)
            {
                listDeque.RemoveAt(0);
                atualizaRelacoes();
            }
            else
                MessageBox.Show("Lista Vazia");
        }        

        public void atualiza()
        {
            dgv.Rows.Clear();
            int i = 0;
            foreach(Deck deque in listDeque)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = i;
                dgv[1, i].Value = deque.esquerda;
                dgv[2, i].Value = deque.direita;
                dgv[3, i].Value = deque.dado;
                i++;
            }
        }
    }
}
