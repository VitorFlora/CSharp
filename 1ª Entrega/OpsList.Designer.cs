namespace HelloWorld
{
    partial class OpsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.labelAltera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RA:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(83, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(83, 41);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.RA});
            this.dgv.Location = new System.Drawing.Point(289, 9);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(244, 192);
            this.dgv.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // RA
            // 
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(27, 81);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(102, 23);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "Inserir Fim";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(27, 119);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(102, 23);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "Inserir Inicio";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(27, 156);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(102, 23);
            this.bt3.TabIndex = 7;
            this.bt3.Text = "Inserir Posição";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(27, 291);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(102, 23);
            this.bt6.TabIndex = 10;
            this.bt6.Text = "Remover  Posição";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(27, 254);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(102, 23);
            this.bt5.TabIndex = 9;
            this.bt5.Text = "Remover Inicio";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(27, 216);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(102, 23);
            this.bt4.TabIndex = 8;
            this.bt4.Text = "Remover Fim";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(138, 159);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(20, 20);
            this.txt3.TabIndex = 3;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(138, 294);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(20, 20);
            this.txt4.TabIndex = 4;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(195, 9);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(84, 23);
            this.bt7.TabIndex = 12;
            this.bt7.Text = "Buscar Nome";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(195, 38);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(84, 23);
            this.bt8.TabIndex = 13;
            this.bt8.Text = "Buscar RA";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(449, 289);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(84, 23);
            this.bt9.TabIndex = 14;
            this.bt9.Text = "Alterar";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(433, 254);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 16;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(433, 216);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 15;
            // 
            // labelAltera
            // 
            this.labelAltera.AutoSize = true;
            this.labelAltera.Location = new System.Drawing.Point(415, 221);
            this.labelAltera.Name = "labelAltera";
            this.labelAltera.Size = new System.Drawing.Size(0, 13);
            this.labelAltera.TabIndex = 17;
            this.labelAltera.Visible = false;
            // 
            // OpsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(548, 327);
            this.Controls.Add(this.labelAltera);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Operações";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label labelAltera;
    }
}