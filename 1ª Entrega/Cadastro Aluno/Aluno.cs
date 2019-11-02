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
    
    public partial class Aluno : Form
    {
        List<Alunoo> listAluno = new List<Alunoo>();

        public Aluno()
        {
            InitializeComponent();
        }

        public void Zerar()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt1.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Alunoo oo = new Alunoo();
            oo.nome = txt1.Text;
            oo.ra = long.Parse(txt2.Text);                        
            listAluno.Add(oo);
            Zerar();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < listAluno.Count(); i++)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = listAluno[i].nome;
                dgv[1, i].Value = listAluno[i].ra;
            }
        }
    }
}
