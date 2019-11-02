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
using System.Diagnostics;
using System.Threading;

namespace HelloWorld
{
    public partial class PesqBinaria : Form
    {
        List<string> listaNome = new List<string>();
        Stopwatch cronometro = new Stopwatch();
        Stopwatch cronometro0 = new Stopwatch();

        public PesqBinaria()
        {
            InitializeComponent();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string linha;
            TextReader tr = new StreamReader("Teste.txt");
            listaNome.Clear();
            while ((linha = tr.ReadLine()) != null)
            {
                listaNome.Add(linha);
            }
            tr.Close();
            Listar();
        }

        void Listar()
        {
            listBox1.Items.Clear();
            foreach(string item in listaNome)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            bool achei = false;
            int inicio = 0;
            int fim = listaNome.Count - 1;
            int pesq = 0;
            int meio = 0;

            cronometro.Reset();
            cronometro.Start();
            while (!achei)
            {
                meio = (inicio + fim) / 2;
                if (txt2.Text.CompareTo(listaNome[meio]) == 0)
                {
                    achei = true;
                    cronometro.Stop();
                }
                else if (txt2.Text.CompareTo(listaNome[meio]) > 0)
                {
                    inicio = meio + 1;
                    cronometro.Stop();
                }
                else
                {
                    fim = meio - 1;
                    cronometro.Stop();
                }
                pesq++;
                Application.DoEvents();
            }

            lbPesq.Text = pesq.ToString();
            txt2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cronometro0.Reset();
            cronometro0.Start();
            int pesqS = 0;
            for (int i = 0;i < listaNome.Count;i++)
            {
                if (txt2.Text == listaNome[i])
                {
                    i = i + listaNome.Count;
                    cronometro0.Stop();
                }
                pesqS++;
            }
            lbPesqS.Text = pesqS.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimerO.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbTimerS.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro0.Elapsed.Hours, cronometro0.Elapsed.Minutes, cronometro0.Elapsed.Seconds, cronometro0.Elapsed.Milliseconds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter tr = new StreamWriter("Teste.txt");
            for (int i = 0; i < 1000; i++)
            {
                tr.WriteLine("Nome" + i);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbPesq.Text = 0.ToString();
            lbPesqS.Text = 0.ToString();
            lbTimerO.Text = "00:00:00:00";
            lbTimerS.Text = "00:00:00:00";
        }
    }
}
