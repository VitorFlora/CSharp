namespace HelloWorld
{
    partial class Ordenação
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbTimerS = new System.Windows.Forms.Label();
            this.lbTimerO = new System.Windows.Forms.Label();
            this.lbPesqS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPesq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btOrd = new System.Windows.Forms.Button();
            this.trocas = new System.Windows.Forms.Label();
            this.lbTrocas = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.lbTimerT = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(143, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 20);
            this.button2.TabIndex = 29;
            this.button2.Text = "Criar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lbTimerS
            // 
            this.lbTimerS.AutoSize = true;
            this.lbTimerS.Location = new System.Drawing.Point(395, 171);
            this.lbTimerS.Name = "lbTimerS";
            this.lbTimerS.Size = new System.Drawing.Size(64, 13);
            this.lbTimerS.TabIndex = 28;
            this.lbTimerS.Text = "00:00:00:00";
            // 
            // lbTimerO
            // 
            this.lbTimerO.AutoSize = true;
            this.lbTimerO.Location = new System.Drawing.Point(395, 112);
            this.lbTimerO.Name = "lbTimerO";
            this.lbTimerO.Size = new System.Drawing.Size(64, 13);
            this.lbTimerO.TabIndex = 27;
            this.lbTimerO.Text = "00:00:00:00";
            // 
            // lbPesqS
            // 
            this.lbPesqS.AutoSize = true;
            this.lbPesqS.Location = new System.Drawing.Point(314, 171);
            this.lbPesqS.Name = "lbPesqS";
            this.lbPesqS.Size = new System.Drawing.Size(13, 13);
            this.lbPesqS.TabIndex = 26;
            this.lbPesqS.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantidade de pesquisas simples";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(408, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "Busca Simples";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPesq
            // 
            this.lbPesq.AutoSize = true;
            this.lbPesq.Location = new System.Drawing.Point(314, 112);
            this.lbPesq.Name = "lbPesq";
            this.lbPesq.Size = new System.Drawing.Size(13, 13);
            this.lbPesq.TabIndex = 23;
            this.lbPesq.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantidade de pesquisas otimizadas";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(299, 6);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(102, 20);
            this.txt2.TabIndex = 21;
            // 
            // btBusca
            // 
            this.btBusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBusca.Location = new System.Drawing.Point(408, 6);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(115, 20);
            this.btBusca.TabIndex = 20;
            this.btBusca.Text = "Busca Otimizada";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click_1);
            // 
            // listar
            // 
            this.listar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listar.Location = new System.Drawing.Point(143, 6);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(60, 20);
            this.listar.TabIndex = 19;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listarLetra_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(8, 7);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(127, 407);
            this.listBox.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btOrd
            // 
            this.btOrd.Location = new System.Drawing.Point(444, 385);
            this.btOrd.Name = "btOrd";
            this.btOrd.Size = new System.Drawing.Size(75, 23);
            this.btOrd.TabIndex = 32;
            this.btOrd.Text = "Ordenar";
            this.btOrd.UseVisualStyleBackColor = true;
            this.btOrd.Click += new System.EventHandler(this.btOrd_Click);
            // 
            // trocas
            // 
            this.trocas.AutoSize = true;
            this.trocas.Location = new System.Drawing.Point(296, 208);
            this.trocas.Name = "trocas";
            this.trocas.Size = new System.Drawing.Size(145, 13);
            this.trocas.TabIndex = 33;
            this.trocas.Text = "Número de Trocas realizadas";
            // 
            // lbTrocas
            // 
            this.lbTrocas.AutoSize = true;
            this.lbTrocas.Location = new System.Drawing.Point(313, 236);
            this.lbTrocas.Name = "lbTrocas";
            this.lbTrocas.Size = new System.Drawing.Size(13, 13);
            this.lbTrocas.TabIndex = 34;
            this.lbTrocas.Text = "0";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Letras",
            "Números",
            "Datas"});
            this.cb.Location = new System.Drawing.Point(299, 32);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(103, 21);
            this.cb.TabIndex = 35;
            // 
            // lbTimerT
            // 
            this.lbTimerT.AutoSize = true;
            this.lbTimerT.Location = new System.Drawing.Point(395, 236);
            this.lbTimerT.Name = "lbTimerT";
            this.lbTimerT.Size = new System.Drawing.Size(64, 13);
            this.lbTimerT.TabIndex = 36;
            this.lbTimerT.Text = "00:00:00:00";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Ordenação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 420);
            this.Controls.Add(this.lbTimerT);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lbTrocas);
            this.Controls.Add(this.trocas);
            this.Controls.Add(this.btOrd);
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
            this.Controls.Add(this.listar);
            this.Controls.Add(this.listBox);
            this.Name = "Ordenação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbTimerS;
        private System.Windows.Forms.Label lbTimerO;
        private System.Windows.Forms.Label lbPesqS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btOrd;
        private System.Windows.Forms.Label trocas;
        private System.Windows.Forms.Label lbTrocas;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label lbTimerT;
        private System.Windows.Forms.Timer timer3;
    }
}