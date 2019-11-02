namespace HelloWorld
{
    partial class Pilha
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
            this.btInsert = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(6, 96);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(100, 23);
            this.btInsert.TabIndex = 0;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(6, 192);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(100, 23);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.letter});
            this.dgv.Location = new System.Drawing.Point(112, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(163, 203);
            this.dgv.TabIndex = 3;
            // 
            // letter
            // 
            this.letter.HeaderText = "Letters";
            this.letter.Name = "letter";
            this.letter.ReadOnly = true;
            this.letter.Width = 120;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(6, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btInsert);
            this.Name = "Pilha";
            this.Text = "Pilha";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn letter;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
    }
}