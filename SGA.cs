using System;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class SGA : Form
    {
        public SGA()
        {
            InitializeComponent();
        }        

        private void helloFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelloFriend hf = new HelloFriend();
            hf.Show();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soma s = new Soma();
            s.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void médiaAritméticaSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media m = new Media();
            m.Show();
        }

        private void médiaAritméticaPonderadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaP mp = new MediaP();
            mp.Show();
            
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imc imc = new Imc();
            imc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void laçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laco l = new Laco();
            l.Show();
        }

        private void calculadoraDeMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriz m = new Matriz();
            m.Show();
        }

        private void jogoDaVelhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Velha v = new Velha();
            v.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluno al = new Aluno();
            al.Show();
        }

        private void maridoDeAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaridoDeAluguel dm = new MaridoDeAluguel();
            dm.Show();
        }

        private void calculadoraSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
        }

        private void listaDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpsList ol = new OpsList();
            ol.Show();
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.Show();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho b = new Baralho();
            b.Show();
        }

        private void dequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deque d = new Deque();
            d.Show();
        }

        private void pesquisaSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa p = new Pesquisa();
            p.Show();
        }

        private void pesquisaBináriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesqBinaria pb = new PesqBinaria();
            pb.Show();
        }

        private void caixaColoridaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pilhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pilha p = new Pilha();
            p.Show();
        }

        private void caixaColoridaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa c = new Caixa();
            c.Show();
        }

        private void ordenaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ordenação o = new Ordenação();
            o.Show();
        }
    }
}
