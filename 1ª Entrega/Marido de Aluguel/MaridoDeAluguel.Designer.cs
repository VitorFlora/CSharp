namespace HelloWorld
{
    partial class MaridoDeAluguel
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Região = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDemandas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.distrubuir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt9 = new System.Windows.Forms.ComboBox();
            this.txt3 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Código:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(75, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Descrição:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(12, 141);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(104, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Qtd. Demanda:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 110);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Região:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Equipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Demanda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome (cliente):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "OS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Região:";
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(125, 48);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "1";
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(125, 139);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 4;
            this.txt4.Text = "0";
            // 
            // txt8
            // 
            this.txt8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt8.Location = new System.Drawing.Point(125, 304);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(100, 20);
            this.txt8.TabIndex = 8;
            // 
            // txt7
            // 
            this.txt7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt7.Location = new System.Drawing.Point(125, 273);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 7;
            // 
            // txt6
            // 
            this.txt6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt6.Location = new System.Drawing.Point(125, 242);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Enabled = false;
            this.txt5.Location = new System.Drawing.Point(125, 211);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 5;
            this.txt5.Text = "1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Descr,
            this.Região,
            this.qtdDemandas});
            this.dgv.Location = new System.Drawing.Point(294, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(420, 148);
            this.dgv.TabIndex = 11;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descr";
            this.Descr.Name = "Descr";
            // 
            // Região
            // 
            this.Região.HeaderText = "Região";
            this.Região.Name = "Região";
            // 
            // qtdDemandas
            // 
            this.qtdDemandas.HeaderText = "Qtd. Deman.";
            this.qtdDemandas.Name = "qtdDemandas";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OS,
            this.Descricao,
            this.NomeClient,
            this.End,
            this.Regiao,
            this.Equipe});
            this.dgv2.Location = new System.Drawing.Point(294, 211);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(420, 146);
            this.dgv2.TabIndex = 12;
            // 
            // add1
            // 
            this.add1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add1.Location = new System.Drawing.Point(239, 137);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(38, 23);
            this.add1.TabIndex = 24;
            this.add1.Text = "Add";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // add2
            // 
            this.add2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add2.Location = new System.Drawing.Point(239, 334);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(38, 23);
            this.add2.TabIndex = 25;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // distrubuir
            // 
            this.distrubuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.distrubuir.Location = new System.Drawing.Point(434, 175);
            this.distrubuir.Name = "distrubuir";
            this.distrubuir.Size = new System.Drawing.Size(163, 23);
            this.distrubuir.TabIndex = 26;
            this.distrubuir.Text = "Distribuir Demandas";
            this.distrubuir.UseVisualStyleBackColor = true;
            this.distrubuir.Click += new System.EventHandler(this.distrubuir_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(230, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(230, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt9
            // 
            this.txt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt9.FormattingEnabled = true;
            this.txt9.Items.AddRange(new object[] {
            "Centro",
            "Norte",
            "Sul",
            "Leste",
            "Oeste"});
            this.txt9.Location = new System.Drawing.Point(125, 333);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(100, 21);
            this.txt9.TabIndex = 9;
            // 
            // txt3
            // 
            this.txt3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt3.FormattingEnabled = true;
            this.txt3.Items.AddRange(new object[] {
            "Centro",
            "Norte",
            "Sul",
            "Leste",
            "Oeste"});
            this.txt3.Location = new System.Drawing.Point(125, 106);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2.Location = new System.Drawing.Point(125, 77);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            // 
            // OS
            // 
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            this.OS.ReadOnly = true;
            this.OS.Width = 35;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descr";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // NomeClient
            // 
            this.NomeClient.HeaderText = "Cliente";
            this.NomeClient.Name = "NomeClient";
            this.NomeClient.ReadOnly = true;
            this.NomeClient.Width = 50;
            // 
            // End
            // 
            this.End.HeaderText = "End.";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            this.End.Width = 80;
            // 
            // Regiao
            // 
            this.Regiao.HeaderText = "Região";
            this.Regiao.Name = "Regiao";
            this.Regiao.ReadOnly = true;
            this.Regiao.Width = 60;
            // 
            // Equipe
            // 
            this.Equipe.HeaderText = "Equipe";
            this.Equipe.Name = "Equipe";
            this.Equipe.ReadOnly = true;
            this.Equipe.Width = 70;
            // 
            // MaridoDeAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(726, 369);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distrubuir);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "MaridoDeAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Região;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDemandas;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button distrubuir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txt9;
        private System.Windows.Forms.ComboBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipe;
    }
}