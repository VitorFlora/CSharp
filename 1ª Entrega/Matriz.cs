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
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }

        int[,] mx = new int[3,3];
        int[,] mx2 = new int[3,3];
        int[,] resp = new int[3,3];
        static string dp;
        static string ds;
        static string c1;
        static string c2;
        static string c3;
        static string l1;
        static string l2;
        static string l3;


        public void matrix()
        {            
            mx[0,0] = int.Parse(box1.Text);
            mx[0,1] = int.Parse(box2.Text);
            mx[0,2] = int.Parse(box3.Text);
            mx[1,0] = int.Parse(box4.Text);
            mx[1,1] = int.Parse(box5.Text);
            mx[1,2] = int.Parse(box6.Text);
            mx[2,0] = int.Parse(box7.Text);
            mx[2,1] = int.Parse(box8.Text);
            mx[2,2] = int.Parse(box9.Text);

            mx2[0,0] = int.Parse(box10.Text);
            mx2[0,1] = int.Parse(box11.Text);
            mx2[0,2] = int.Parse(box12.Text);
            mx2[1,0] = int.Parse(box13.Text);
            mx2[1,1] = int.Parse(box14.Text);
            mx2[1,2] = int.Parse(box15.Text);
            mx2[2,0] = int.Parse(box16.Text);
            mx2[2,1] = int.Parse(box17.Text);
            mx2[2,2] = int.Parse(box18.Text);
        }
        
        public void respost()
        {
            box19.Text = resp[0,0].ToString();
            box20.Text = resp[0,1].ToString();
            box21.Text = resp[0,2].ToString();
            box22.Text = resp[1,0].ToString();
            box23.Text = resp[1,1].ToString();
            box24.Text = resp[1,2].ToString();
            box25.Text = resp[2,0].ToString();
            box26.Text = resp[2,1].ToString();
            box27.Text = resp[2,2].ToString();
        }

        public void pegaNumeros(int i, int j)
        {
            if (i == j)
            {
                if (String.IsNullOrEmpty(dp))
                {
                    dp += resp[i, j].ToString();
                }
                else
                    dp += "; " + resp[i, j].ToString();
            }
            if (i == 0)
            {
                if (String.IsNullOrEmpty(l1))
                {
                    l1 += resp[i, j].ToString();
                }
                else
                    l1 += "; " + resp[i, j].ToString();
            }
            if (i == 1)
            {
                if (String.IsNullOrEmpty(l2))
                {
                    l2 += resp[i, j].ToString();
                }
                else
                    l2 += "; " + resp[i, j].ToString();
            }
            if (i == 2)
            {
                if (String.IsNullOrEmpty(l3))
                {
                    l3 += resp[i, j].ToString();
                }
                else
                    l3 += "; " + resp[i, j].ToString();
            }
            if (j == 0)
            {
                if (String.IsNullOrEmpty(c1))
                {
                    c1 += resp[i, j].ToString();
                }
                else
                    c1 += "; " + resp[i, j].ToString();
            }
            if (j == 1)
            {
                if (String.IsNullOrEmpty(c2))
                {
                    c2 += resp[i, j].ToString();
                }
                else
                    c2 += "; " + resp[i, j].ToString();
            }
            if (j == 2)
            {
                if (String.IsNullOrEmpty(c3))
                {
                    c3 += resp[i, j].ToString();
                }
                else
                    c3 += "; " + resp[i, j].ToString();
            }
            if ((i + j) == 2)
            {
                if (String.IsNullOrEmpty(ds))
                {
                    ds += resp[i, j].ToString();
                }
                else
                    ds += "; " + resp[i, j].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (box1.Text != "" && box2.Text != "" && box3.Text != "" && box4.Text != "" && box5.Text != "" && box6.Text != "" && box7.Text != "" && box8.Text != "" && box9.Text != "" && box10.Text != "" && box11.Text != "" && box12.Text != "" && box13.Text != "" && box14.Text != "" && box5.Text != "" && box6.Text != "" && box17.Text != "" && box18.Text != "")
            //{
            matrix();
            for(int i = 0; i < 3;i++)
            {
                for(int j = 0;j < 3;j++)
                {
                    resp[i, j] = mx[i, j] + mx2[i, j];
                    pegaNumeros(i, j);
                }
            }
            respost();

            //}
            //else
            //  MessageBox.Show("Informação invalida");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (box1.Text != "" && box2.Text != "" && box3.Text != "" && box4.Text != "" && box5.Text != "" && box6.Text != "" && box7.Text != "" && box8.Text != "" && box9.Text != "" && box10.Text != "" && box11.Text != "" && box12.Text != "" && box13.Text != "" && box14.Text != "" && box5.Text != "" && box6.Text != "" && box17.Text != "" && box18.Text != "")
            //{
                matrix();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        resp[i, j] = mx[i, j] - mx2[i, j];
                        pegaNumeros(i, j);
                    }
                }
                respost();
            //}
            //else
            //    MessageBox.Show("Informação invalida");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (box1.Text != "" && box2.Text != "" && box3.Text != "" && box4.Text != "" && box5.Text != "" && box6.Text != "" && box7.Text != "" && box8.Text != "" && box9.Text != "" && box10.Text != "" && box11.Text != "" && box12.Text != "" && box13.Text != "" && box14.Text != "" && box5.Text != "" && box6.Text != "" && box17.Text != "" && box18.Text != "")
            //{
                matrix();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        resp[i, j] = mx[i, j] * mx2[i, j];
                        pegaNumeros(i, j);
                    }
                }
                respost();
            //}
            //else
            //    MessageBox.Show("Informação invalida");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (box1.Text != "" && box2.Text != "" && box3.Text != "" && box4.Text != "" && box5.Text != "" && box6.Text != "" && box7.Text != "" && box8.Text != "" && box9.Text != "" && box10.Text != "" && box11.Text != "" && box12.Text != "" && box13.Text != "" && box14.Text != "" && box5.Text != "" && box6.Text != "" && box17.Text != "" && box18.Text != "")
            //{
                matrix();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        resp[i, j] = mx[i, j] / mx2[i, j];
                        pegaNumeros(i, j);
                    }
                }
                respost();
            //}
            //else
            //    MessageBox.Show("Informação invalida");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = l1;
            l1 = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = l2;
            l2 = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = l3;
            l3 = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = c1;
            c1 = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = c2;
            c2 = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = c3;
            c3 = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = dp;
            dp = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BoxResp.Text = "";
            BoxResp.Text = ds;
            ds = "";
        }

    }
}
