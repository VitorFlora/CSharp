namespace HelloWorld
{
    partial class PesqBinaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btListar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPesq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPesqS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTimerO = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbTimerS = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListar
            // 
            this.btListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btListar.Location = new System.Drawing.Point(12, 16);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 20);
            this.btListar.TabIndex = 5;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 186);
            this.listBox1.TabIndex = 4;
            // 
            // btBusca
            // 
            this.btBusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBusca.Location = new System.Drawing.Point(241, 16);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(115, 20);
            this.btBusca.TabIndex = 6;
            this.btBusca.Text = "Busca Otimizada";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(152, 16);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(82, 20);
            this.txt2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de pesquisas otimizadas";
            // 
            // lbPesq
            // 
            this.lbPesq.AutoSize = true;
            this.lbPesq.Location = new System.Drawing.Point(250, 125);
            this.lbPesq.Name = "lbPesq";
            this.lbPesq.Size = new System.Drawing.Size(13, 13);
            this.lbPesq.TabIndex = 9;
            this.lbPesq.Text = "0";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(241, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Busca Simples";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPesqS
            // 
            this.lbPesqS.AutoSize = true;
            this.lbPesqS.Location = new System.Drawing.Point(250, 184);
            this.lbPesqS.Name = "lbPesqS";
            this.lbPesqS.Size = new System.Drawing.Size(13, 13);
            this.lbPesqS.TabIndex = 12;
            this.lbPesqS.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade de pesquisas simples";
            // 
            // lbTimerO
            // 
            this.lbTimerO.AutoSize = true;
            this.lbTimerO.Location = new System.Drawing.Point(292, 125);
            this.lbTimerO.Name = "lbTimerO";
            this.lbTimerO.Size = new System.Drawing.Size(64, 13);
            this.lbTimerO.TabIndex = 13;
            this.lbTimerO.Text = "00:00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbTimerS
            // 
            this.lbTimerS.AutoSize = true;
            this.lbTimerS.Location = new System.Drawing.Point(292, 184);
            this.lbTimerS.Name = "lbTimerS";
            this.lbTimerS.Size = new System.Drawing.Size(64, 13);
            this.lbTimerS.TabIndex = 14;
            this.lbTimerS.Text = "00:00:00:00";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(381, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 20);
            this.button2.TabIndex = 15;
            this.button2.Text = "Criar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLimpar.Location = new System.Drawing.Point(379, 208);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(52, 20);
            this.btLimpar.TabIndex = 17;
            this.btLimpar.Text = "limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // PesqBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 239);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbTimerS);
            this.Controls.Add(this.lbTimerO);
            this.Controls.Add(this.lbPesqS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPesq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.listBox1);
            this.Name = "PesqBinaria";
            this.Text = "Pesquisa Otimizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPesq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPesqS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTimerO;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbTimerS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btLimpar;
    }
}