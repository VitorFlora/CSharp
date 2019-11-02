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
    public partial class Imc : Form
    {
        string sexo;
        double altura;
        double peso;
        double imc;

        public Imc()
        {
            InitializeComponent();
        }
        
        private void btn_mal_Click(object sender, EventArgs e)
        {
            sexo = "0";
            if (sexo == "0")
            {
                sex.Text = sexo = "Masculino";
            }
        }

        private void btn_fem_Click(object sender, EventArgs e)
        {
            sexo = "1";
            if (sexo == "1")
            {
                sex.Text = sexo = "Feminino";
            }
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            sexo = "2";
            if (sexo == "2")
            {
                sex.Text = sexo = "Não seiKKKK";
            }
        }

        private void cal_Click(object sender, EventArgs e)
        {
            altura = double.Parse(text1.Text);
            peso = double.Parse(text2.Text);
            imc = (peso/(altura * altura));
            num_imc.Text = Math.Round(imc,2).ToString();

            if(sexo == "Masculino")
            {
                if(imc < 20)
                {
                    result_imc.Text = ("Abaixo do peso");
                }else 
                    if(imc >= 20 && imc <= 24.9)
                    {
                        result_imc.Text = ("No peso certo!");
                    }else
                        if(imc >= 25 && imc <= 29.9)
                        {
                            result_imc.Text = ("Obesidade leve");
                        }else
                            if(imc >= 30 && imc <= 39.9)
                            {
                                result_imc.Text = ("Obesidade Moderada");
                            }else
                                if(imc >= 40)
                                {
                                    result_imc.Text = ("Obesidade Mórbida");
                                }
            }else 
                if(sexo == "Feminino")
                {
                   if(imc < 19)
                {
                    result_imc.Text = ("Abaixo do peso");
                }else 
                    if(imc >= 19 && imc <= 23.9)
                    {
                        result_imc.Text = ("No peso certo!");
                    }else
                        if(imc >= 24 && imc <= 28.9)
                        {
                            result_imc.Text = ("Obesidade leve");
                        }else
                            if(imc >= 29 && imc <= 38.9)
                            {
                                result_imc.Text = ("Obesidade Moderada");
                            }else
                                if(imc > 38.9)
                                {
                                    result_imc.Text = ("Obesidade Mórbida");
                                }
            }else 
                if(sexo == "Não seiKKKK")
                {
                    result_imc.Text = ("Num dá ô merda");
                }
        }
        private void calcu_entre()
        {
            Calculator calculator = new Calculator();
            calculator.limpar();
            text1.Clear();
            text2.Clear();
            sex.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcu_entre();
        }

        private void Imc_Load(object sender, EventArgs e)
        {

        }
    }
}
