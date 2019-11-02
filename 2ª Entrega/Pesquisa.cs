using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Pesquisa : Form
    {
        List<string> listaNome = new List<string>();
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string linha;
            listaNome.Clear();
            TextReader tr = new StreamReader("lista.txt");
            while ((linha = tr.ReadLine()) != null)
            {
                listaNome.Add(linha);
            }
            tr.Close();
            listar();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Pesquisa Simples
            listBox1.Items.Clear();
            foreach (string item in listaNome)
            {
                if (item == txt1.Text)
                    listBox1.Items.Add(item);
            }
        }
        void listar()
        {
            listBox1.Items.Clear();
            foreach (string item in listaNome)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pesquisa Otimizada
            int i = 0;
            listBox1.Items.Clear();
            if (txt1.Text == listaNome[listaNome.Count - 1].ToString())
            {
                listBox1.Items.Add(listaNome[listaNome.Count - 1].ToString());
            }
            else if (txt1.Text == listaNome[0].ToString())
            {
                listBox1.Items.Add(listaNome[0].ToString());
            }else
            {
                //Sentinel
                int count = listaNome.Count;
                listaNome.Add(txt1.Text);
                while (listaNome[i].ToString() != txt1.Text)
                {
                    i++;
                }
                if (i < count)
                {
                    listBox1.Items.Add(listaNome[i].ToString());
                }
                else
                {
                    MessageBox.Show("Não encontrado");
                    button1_Click(sender, e);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Busca dinâmica, a cada letra
            if (txt2.Text != "")
            {
                listBox1.Items.Clear();
                string nome = txt2.Text;
                foreach (string item in listaNome)
                {
                    if (item.Length >= nome.Length)
                    {
                        if (item.Substring(0, nome.Length) == nome)
                            listBox1.Items.Add(item);
                    }
                }
            }
        }
    }
}
