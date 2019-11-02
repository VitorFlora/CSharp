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
    public partial class Baralho : Form
    {
        public Baralho()
        {
            InitializeComponent();
        }

        List<Carta> listCarta = new List<Carta>();
        List<Carta> listMeio = new List<Carta>();
        Stack<Carta> pilhaCarta = new Stack<Carta>();
        int numRand;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        public void add()
        {
            Carta carta = new Carta();
            listMeio.Clear();
            carta.numero = txtNum.Text;
            carta.naipe = txtNaipe.Text;
            carta.valor = int.Parse(txtValor.Text);
            listCarta.Add(carta);
            atualiza();
            txtNum.Text = "";
            txtNaipe.Text = "";
            txtValor.Text = "";
            txtNum.Focus();
        }

        public void atualiza()
        {
            dgv1.Rows.Clear();
            for (int i = 0;i < listCarta.Count();i++)
            {
                dgv1.Rows.Add();
                dgv1[0, i].Value = listCarta[i].numero;
                dgv1[1, i].Value = listCarta[i].naipe;
                dgv1[2, i].Value = listCarta[i].valor;
            }
        }

        public void atualizaEmbaralhado()
        {
            dgv2.Rows.Clear();
            Carta[] Embaralhadas = new Carta[pilhaCarta.Count()];
            Embaralhadas = pilhaCarta.ToArray();
            for(int i = 0; i< Embaralhadas.Count(); i++)
            {
                dgv2.Rows.Add();
                dgv2[0, i].Value = Embaralhadas[i].numero;
                dgv2[1, i].Value = Embaralhadas[i].naipe;
                dgv2[2, i].Value = Embaralhadas[i].valor;
            }
        }
        private void btnEmbaralha_Click(object sender, EventArgs e)
        {
            CarregaMeio();
            Random rand = new Random();
            pilhaCarta.Clear();
            while(listMeio.Count() > 0)
            {
                numRand = rand.Next(listMeio.Count);
                pilhaCarta.Push(listMeio[numRand]);
                listMeio.RemoveAt(numRand);
            }
            atualizaEmbaralhado();
        }
        public void CarregaMeio()
        {
            for(int i = 0; i < listCarta.Count(); i++)
            {
                listMeio.Add(listCarta[i]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtNaipe.Text = "";
            txtValor.Text = "";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pilhaCarta.Pop();
            atualizaEmbaralhado();
        }
    }
}
