namespace HelloWorld
{
    partial class Soma
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.res = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.res);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 236);
            this.panel1.TabIndex = 1;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(135, 181);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 17);
            this.res.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(135, 61);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(116, 23);
            this.text2.TabIndex = 4;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(135, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(116, 23);
            this.text1.TabIndex = 3;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primeiro número:";
            // 
            // Soma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(287, 260);
            this.Controls.Add(this.panel1);
            this.Name = "Soma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}