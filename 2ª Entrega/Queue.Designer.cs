namespace HelloWorld
{
    partial class Queue
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
            this.btadd = new System.Windows.Forms.Button();
            this.btremove = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(145, 3);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(80, 23);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "+";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btremove
            // 
            this.btremove.Location = new System.Drawing.Point(12, 3);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(83, 23);
            this.btremove.TabIndex = 4;
            this.btremove.Text = "-";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num});
            this.dgv.Location = new System.Drawing.Point(12, 32);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(213, 146);
            this.dgv.TabIndex = 6;
            // 
            // num
            // 
            this.num.HeaderText = "Número";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 170;
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(237, 190);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.btadd);
            this.Name = "Queue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
    }
}