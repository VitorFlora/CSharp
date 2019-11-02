namespace HelloWorld
{
    partial class Deque
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
            this.txtDado = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(12, 25);
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(88, 20);
            this.txtDado.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Dado:";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(29, 63);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(62, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(29, 92);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(62, 23);
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
            this.indice,
            this.antecessor,
            this.sucessor,
            this.dado});
            this.dgv.Location = new System.Drawing.Point(115, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(280, 124);
            this.dgv.TabIndex = 3;
            // 
            // indice
            // 
            this.indice.HeaderText = "Índice";
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Width = 50;
            // 
            // antecessor
            // 
            this.antecessor.HeaderText = "Antecessor";
            this.antecessor.Name = "antecessor";
            this.antecessor.ReadOnly = true;
            this.antecessor.Width = 65;
            // 
            // sucessor
            // 
            this.sucessor.HeaderText = "Sucessor";
            this.sucessor.Name = "sucessor";
            this.sucessor.ReadOnly = true;
            this.sucessor.Width = 60;
            // 
            // dado
            // 
            this.dado.HeaderText = "Dado";
            this.dado.Name = "dado";
            this.dado.ReadOnly = true;
            this.dado.Width = 50;
            // 
            // Deque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 161);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtDado);
            this.Name = "Deque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dado;
    }
}