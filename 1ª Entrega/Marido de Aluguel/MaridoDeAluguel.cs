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
    public partial class MaridoDeAluguel : Form
    {
        List<Cliente> listDemanda = new List<Cliente>();
        List<Equipe> listEquipe = new List<Equipe>();

        public MaridoDeAluguel()
        {
            InitializeComponent();
        }

        public void atualizarEquipe()
        {
            dgv.Rows.Clear();
            for (int i = 0; i < listEquipe.Count(); i++)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = listEquipe[i].codigo;
                dgv[1, i].Value = listEquipe[i].descrEquipe;
                dgv[2, i].Value = listEquipe[i].regEquipe;
                dgv[3, i].Value = listEquipe[i].qtdEquipe;
            }
        }

        public void atualizarDemandas()
        {            
            dgv2.Rows.Clear();
            for (int i = 0; i < listDemanda.Count(); i++)
            {
                dgv2.Rows.Add();
                dgv2[0, i].Value = listDemanda[i].os;
                dgv2[1, i].Value = listDemanda[i].descrDemanda;
                dgv2[2, i].Value = listDemanda[i].nome;
                dgv2[3, i].Value = listDemanda[i].endereco;
                dgv2[4, i].Value = listDemanda[i].regDemanda;
                dgv2[5, i].Value = listDemanda[i].equipeAtd;
            }
        }

        
        private void add1_Click(object sender, EventArgs e)
        {
            Equipe eq = new Equipe();
            if(eq.codigo.ToString() != "" || eq.descrEquipe != "" || eq.regEquipe != "" || eq.qtdEquipe.ToString() != "")
            {
                eq.codigo = int.Parse(txt1.Text);
                eq.descrEquipe = txt2.Text;
                eq.regEquipe = txt3.Text;
                eq.qtdEquipe = int.Parse(txt4.Text);
                listEquipe.Add(eq);
                MessageBox.Show("Equipe adicionada com sucesso");
                txt1.Text = (int.Parse(txt1.Text) + 1).ToString();
                txt2.Text = "";
                txt3.Text = "";
                txt2.Focus();
            }
            else
                MessageBox.Show("Dados invalidos");
        }

        private void add2_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            if (cl.os.ToString() != "" || cl.descrDemanda != "" || cl.nome != "" || cl.endereco != "" || cl.regDemanda != "" || cl.equipeAtd != "")
            {
                cl.os = int.Parse(txt5.Text);
                cl.descrDemanda = txt6.Text;
                cl.nome = txt7.Text;
                cl.endereco = txt8.Text;
                cl.regDemanda = txt9.Text;
                listDemanda.Add(cl);
                MessageBox.Show("Demanda adicionada com sucesso");
                txt5.Text = (int.Parse(txt5.Text) + 1).ToString();
                txt6.Text = "";
                txt7.Text = "";
                txt8.Text = "";
                txt6.Focus();
            }
            else
                MessageBox.Show("Informação invalida");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarEquipe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualizarDemandas();
        }        

        private void distrubuir_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < listEquipe.Count(); i++)
            {
                for(int j = 0;j < listDemanda.Count(); j++)
                {
                    if (listDemanda[i].regDemanda == listEquipe[i].regEquipe)
                    {
                        listDemanda[i].equipeAtd = listEquipe[i].regEquipe + "/" + listEquipe[i].codigo;
                        listEquipe[i].qtdEquipe = listEquipe[i].qtdEquipe + 1;
                    }
                    else
                        MessageBox.Show("Não existe Equipe equivalente", "Sinto muito", 0);
                }
            }
            atualizarDemandas();
            atualizarEquipe();

        }
    }
}
