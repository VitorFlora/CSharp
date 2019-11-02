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
    public partial class OpsList : Form
    {
        List<Alunoo> listAnulo = new List<Alunoo>();
        Alunoo anulo = new Alunoo();
        Alunoo anuloRes = new Alunoo();

        public OpsList()
        {
            InitializeComponent();
        }

        Alunoo altera()
        {
            Alunoo AlteraAluno = new Alunoo();
            AlteraAluno.nome = txt5.Text;
            AlteraAluno.ra = long.Parse(txt6.Text);
            return AlteraAluno;
        }

        public void add()
        {
            anulo.nome = txt1.Text;
            anulo.ra = long.Parse(txt2.Text);
            txt1.Text = "";
            txt2.Text = "";
        }

        public void atualiza()
        {
            dgv.Rows.Clear();
            for (int i = 0; i < listAnulo.Count; i++)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = listAnulo[i].nome;
                dgv[1, i].Value = listAnulo[i].ra;
            }
            txt1.Focus();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                add();
                listAnulo.Add(anulo);
                atualiza();
            }
            else
                MessageBox.Show("Campo de nome e/ou ra vazio", "Ops", 0);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                add();
                listAnulo.Insert(0, anulo);
                atualiza();
            }
            else
                MessageBox.Show("Campo de nome e/ou ra vazio", "Ops", 0);
        }

        private void bt3_Click(object sender, EventArgs e)
        {            
            if (txt1.Text != "" && txt2.Text != "")
            {
                if (txt3.Text != "")
                {
                    if (int.Parse(txt3.Text) <= listAnulo.Count)
                    {
                        add();
                        listAnulo.Insert(int.Parse(txt3.Text), anulo);
                        atualiza();
                        txt3.Text = "";
                    }
                    else
                        MessageBox.Show("Insira uma posição válida", "Ops", 0);
                }
                else
                    MessageBox.Show("Insira alguma coisa", "Ops", 0);
            }
            else
                MessageBox.Show("Campo de nome e/ou ra vazio", "Ops", 0);

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (listAnulo.Count > 0)
            {
                listAnulo.RemoveAt(listAnulo.Count - 1);
                atualiza();
            }
            else
                MessageBox.Show("Lista vazia", "Ops", 0);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (listAnulo.Count > 0)
            {
                listAnulo.RemoveAt(0);
                atualiza();
            }
            else
                MessageBox.Show("Lista vazia", "Ops", 0);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (listAnulo.Count > 0)
            {
                if (txt4.Text != "")
                {
                    if (int.Parse(txt4.Text) <= listAnulo.Count)
                    {
                        listAnulo.RemoveAt(int.Parse(txt4.Text));
                        atualiza();
                        txt4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Insira uma posição válida", "Ops", 0);
                        txt4.Text = "";
                    }
                }
                else
                    MessageBox.Show("Insira uma posição", "Ops", 0);
            }
            else
                MessageBox.Show("Lista vazia", "Ops", 0);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (listAnulo.Count > 0)
            {
                if (txt1.Text != "")
                {
                    for (int i = 0; i < listAnulo.Count(); i++)
                    {
                        if (anuloRes.nome != "")
                        {
                            anuloRes = listAnulo.Find(anulo => anulo.nome == txt1.Text);
                            labelAltera.Text = listAnulo.FindIndex(alunos => alunos.nome == txt1.Text).ToString();
                            txt6.Enabled = true;
                            txt5.Enabled = true;
                            txt6.Text = anuloRes.ra.ToString();
                            txt5.Text = anuloRes.nome;
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("Campo de Nome vazio", "Ops", 0);
            }
            else
                MessageBox.Show("Lista vazia", "Ops", 0);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (listAnulo.Count() > 0)
            {
                if (txt2.Text != "")
                {
                    for (int i = 0; i < listAnulo.Count(); i++)
                    {
                        anuloRes = listAnulo.Find(anulo => anulo.ra.ToString() == txt2.Text);
                        if (anuloRes.ra.ToString() != "")
                        {
                            labelAltera.Text = listAnulo.FindIndex(alunos => alunos.ra == long.Parse(txt2.Text)).ToString();
                            txt6.Enabled = true;
                            txt5.Enabled = true;
                            txt6.Text = anuloRes.ra.ToString();
                            txt5.Text = anuloRes.nome;
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("Campo de RA vazio", "Ops", 0);
            }
            else
                MessageBox.Show("Lista vazia", "Ops", 0);

        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (labelAltera.Text == "")
            {
                MessageBox.Show("Nenhuma Busca Realizada", "Ops", 0);
            }
            else
            {
                if (txt5.Text != "" && txt6.Text != "")
                {
                    Alunoo AlteraAluno = altera();
                    listAnulo[int.Parse(labelAltera.Text)] = AlteraAluno;
                    atualiza();
                    txt5.Text = "";
                    txt6.Text = "";
                }
                else
                    MessageBox.Show("Campo de nome e/ou ra vazio", "Ops", 0);
            }
        }
    }
}
