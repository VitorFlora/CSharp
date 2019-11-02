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
    public partial class Velha : Form
    {
        static string nome1, nome2, jogada, quemGanhou;
        static string[,] vm = new string[3,3];        

        public Velha()
        {
            InitializeComponent();
        }

        private void limpar_Click_1(object sender, EventArgs e)
        {
            nome1 = "";
            nome2 = "";
            quemGanhou = "";
            jogada = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vm[i, j] = "";
                }
            }
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";
            p1.Text = "";
            p2.Text = "";
            ganhador.Text = "";
            radio1.Visible = false;
            radio2.Visible = false;
            button1.Visible = true;
        }

        public void DefineVez()
        {
            if (jogada == "X")
            {
                jogada = "O";
                radio1.Visible = false;
                radio1.Checked = false;
                radio2.Visible = true;
                radio2.Checked = true;
            }
            else
            {
                jogada = "X";
                radio2.Visible = false;
                radio2.Checked = false;
                radio1.Visible = true;
                radio1.Checked = true;
            }
        }

        private void box1_Click(object sender, EventArgs e)
        {
            box1.Text = jogada;
            vm[0, 0] = jogada;
            DefineVez();
            box1.Enabled = false;
            verificaGanhador();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            box2.Text = jogada;
            vm[0, 1] = jogada;
            DefineVez();
            box2.Enabled = false;
            verificaGanhador();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            box3.Text = jogada;
            vm[0, 2] = jogada;
            DefineVez();
            box3.Enabled = false;
            verificaGanhador();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            box4.Text = jogada;
            vm[1, 0] = jogada;
            DefineVez();
            box4.Enabled = false;
            verificaGanhador();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            box5.Text = jogada;
            vm[1, 1] = jogada;
            DefineVez();
            box5.Enabled = false;
            verificaGanhador();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            box6.Text = jogada;
            vm[1, 2] = jogada;
            DefineVez();
            box6.Enabled = false;
            verificaGanhador();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            box7.Text = jogada;
            vm[2, 0] = jogada;
            DefineVez();
            box7.Enabled = false;
            verificaGanhador();
        }           

        private void box8_Click(object sender, EventArgs e)
        {
            box8.Text = jogada;
            vm[2, 1] = jogada;
            DefineVez();
            box8.Enabled = false;
            verificaGanhador();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            box9.Text = jogada;
            vm[2, 2] = jogada;
            DefineVez();
            box9.Enabled = false;
            verificaGanhador();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            nome1 = p1.Text;
            nome2 = p2.Text;

            if (nome1 == "" && nome2 == "")
                MessageBox.Show("Insira algum nome");
            else
            {
                radio1.Visible = true;
                radio1.Checked = true;
                jogada = "X";
                box1.Text = "";
                box2.Text = "";
                box3.Text = "";
                box4.Text = "";
                box5.Text = "";
                box6.Text = "";
                box7.Text = "";
                box8.Text = "";
                box9.Text = "";
                box1.Enabled = true;
                box2.Enabled = true;
                box3.Enabled = true;
                box4.Enabled = true;
                box5.Enabled = true;
                box6.Enabled = true;
                box7.Enabled = true;
                box8.Enabled = true;
                box9.Enabled = true;
            }

            
        }

        public void verificaGanhador()
        {
            //Primeira Linha
            if (!String.IsNullOrEmpty(vm[0, 0]))
            {
                if (vm[0, 0] == vm[0, 1] && vm[0, 1] == vm[0, 2])
                {
                    if (vm[0, 0] == "X"){ 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
            }
            }
            //Segunda Linha
            if (!String.IsNullOrEmpty(vm[1, 0]))
            {

                if (vm[1, 0] == vm[1, 1] && vm[1, 1] == vm[1, 2])
                {
                    if (vm[1, 0] == "X")
                    {
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
            }
            }
            //Terceira Linha
            if (!String.IsNullOrEmpty(vm[2, 0]))
            {

                if (vm[2, 0] == vm[2, 1] && vm[2, 1] == vm[2, 2])
                {                    
                    if (vm[2, 0] == "X") { 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
            }
            }
            //Primeira Coluna
            if (!String.IsNullOrEmpty(vm[0, 0]))
            {

                if (vm[0, 0] == vm[1, 0] && vm[1, 0] == vm[2, 0])
                {                    
                    if (vm[0, 0] == "X") { 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                }
            }
            //Segunda Coluna
            if (!String.IsNullOrEmpty(vm[0, 1]))
            {

                if (vm[0, 1] == vm[1, 1] && vm[1, 1] == vm[2, 1])
                {                    
                    if (vm[0, 1] == "X") { 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                }
            }
            //Terceira Coluna
            if (!String.IsNullOrEmpty(vm[0, 2]))
            {

                if (vm[0, 2] == vm[1, 2] && vm[1, 2] == vm[2, 2])
                {                    
                    if (vm[0, 2] == "X") { 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                }
            }
            //Diagonal Principal
            if (!String.IsNullOrEmpty(vm[0, 0]))
            {

                if (vm[0, 0] == vm[1, 1] && vm[2, 2] == vm[1, 1])
                {                    
                    if (vm[0, 0] == "X") { 
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else { 
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                }
            }
            //Diagonal Secundaria
            if (!String.IsNullOrEmpty(vm[0, 2]))
            {

                if (vm[0, 2] == vm[1, 1] && vm[2, 0] == vm[1, 1])
                {                    
                    if (vm[0, 2] == "X"){
                        quemGanhou = nome1 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                    else{
                        quemGanhou = nome2 + " ganhou, Parabéns!";
                        button1.Visible = false;
                    }
                }
            }

            if (!String.IsNullOrEmpty(box1.Text) && !String.IsNullOrEmpty(box2.Text)
                && !String.IsNullOrEmpty(box3.Text) && !String.IsNullOrEmpty(box4.Text)
                && !String.IsNullOrEmpty(box5.Text) && !String.IsNullOrEmpty(box6.Text)
                && !String.IsNullOrEmpty(box7.Text) && !String.IsNullOrEmpty(box8.Text)
                && !String.IsNullOrEmpty(box9.Text))
            {
                quemGanhou = "Deu Velha! :(";

            }

            if (!String.IsNullOrEmpty(quemGanhou))
            {
                ganhador.Text = quemGanhou;
                box1.Enabled = false;
                box2.Enabled = false;
                box3.Enabled = false;
                box4.Enabled = false;
                box5.Enabled = false;
                box6.Enabled = false;
                box7.Enabled = false;
                box8.Enabled = false;
                box9.Enabled = false;
                limpar.Visible = true;
            }
        }
    }
                
}
