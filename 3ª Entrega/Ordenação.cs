using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Ordenação : Form
    {
        public Ordenação()
        {
            InitializeComponent();
        }

        List<string> listaNome = new List<string>();
        List<int> listNum = new List<int>();
        List<string> listTxt = new List<string>();
        List<DateTime> listDate = new List<DateTime>();
        Stopwatch cronometro = new Stopwatch();
        Stopwatch cronometro0 = new Stopwatch();
        Stopwatch cronometro1 = new Stopwatch();
        string linha;
        int troca;
        string trocaTxt;
        DateTime trocaD;
        int qtdTroca;

        void Listar()
        {
            if (cb.SelectedIndex == 0)
            {
                listBox.Items.Clear();
                foreach (string item in listTxt)
                {
                    listBox.Items.Add(item);
                }
            }
            else if (cb.SelectedIndex == 1)
            {
                listBox.Items.Clear();
                foreach (int item in listNum)
                {
                    listBox.Items.Add(item);
                }
            }
            else
            {
                listBox.Items.Clear();
                foreach (DateTime item in listDate)
                {
                    listBox.Items.Add(item);
                }
            }
        }
        private void listarLetra_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0)
            {
                TextReader tr = new StreamReader("a.txt");
                listTxt.Clear();
                while ((linha = tr.ReadLine()) != null)
                {
                    listTxt.Add(linha);
                }
                tr.Close();
                Listar();
            }
            else if (cb.SelectedIndex == 1)
            {
                TextReader tr = new StreamReader("1.txt");
                listNum.Clear();
                while ((linha = tr.ReadLine()) != null)
                {
                    listNum.Add(int.Parse(linha));
                }
                tr.Close();
                Listar();
            }
            else
            {
                TextReader tr = new StreamReader("date.txt");
                listDate.Clear();
                while ((linha = tr.ReadLine()) != null)
                {
                    listDate.Add(DateTime.Parse(linha));
                }
                tr.Close();
                Listar();
            }
        }
        private void btOrd_Click(object sender, EventArgs e)
        {            
            if (cb.SelectedIndex == 0)
            {
                cronometro1.Reset();
                cronometro1.Start();
                lbTrocas.Text = "0";
                qtdTroca = 0;
                listBox.Items.Clear();
                for (int i = 0; i < listTxt.Count - 1; i++)
                {
                    for (int j = i + 1; j < listTxt.Count; j++)
                    {
                        if (listTxt[i].CompareTo(listTxt[j]) == 1)
                        {
                            trocaTxt = listTxt[i];
                            listTxt[i] = listTxt[j];
                            listTxt[j] = trocaTxt;
                            qtdTroca++;
                            Application.DoEvents();
                        }
                    }
                }
                cronometro1.Stop();
                lbTrocas.Text = qtdTroca.ToString();
            }
            else if (cb.SelectedIndex == 1)
            {
                cronometro1.Reset();
                cronometro1.Start();
                lbTrocas.Text = "0";
                qtdTroca = 0;
                listBox.Items.Clear();
                for (int i = 0; i < listNum.Count - 1; i++)
                {
                    for (int j = i + 1; j < listNum.Count; j++)
                    {
                        if (listNum[i] > listNum[j])
                        {
                            troca = listNum[i];
                            listNum[i] = listNum[j];
                            listNum[j] = troca;
                            qtdTroca++;
                            Application.DoEvents();
                        }
                    }
                }
                cronometro1.Stop();
                lbTrocas.Text = qtdTroca.ToString();
            }
            else
            {
                cronometro1.Reset();
                cronometro1.Start();
                lbTrocas.Text = "0";
                qtdTroca = 0;
                listBox.Items.Clear();
                for (int i = 0; i < listDate.Count - 1; i++)
                {
                    for (int j = i + 1; j < listDate.Count; j++)
                    {
                        if (listDate[i].CompareTo(listDate[j]) == 1)
                        {
                            trocaD = listDate[i];
                            listDate[i] = listDate[j];
                            listDate[j] = trocaD;
                            qtdTroca++;
                            Application.DoEvents();
                        }
                    }
                }
                cronometro1.Stop();
                lbTrocas.Text = qtdTroca.ToString();
            }
            Listar();
            cronometro1.Stop();
        }

        private void btBusca_Click_1(object sender, EventArgs e)
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
            for (int i = 0; i < listaNome.Count; i++)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            TextWriter tw = new StreamWriter("1.txt");
            for (int i = 0; i < 1000; i++)
            {
                tw.WriteLine(rand.Next(1, 900));
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTimerO.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbTimerS.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro0.Elapsed.Hours, cronometro0.Elapsed.Minutes, cronometro0.Elapsed.Seconds, cronometro0.Elapsed.Milliseconds);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbTimerT.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro1.Elapsed.Hours, cronometro1.Elapsed.Minutes, cronometro1.Elapsed.Seconds, cronometro1.Elapsed.Milliseconds);
        }
    }
}
