namespace HelloWorld
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Label();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.rest);
            this.panel1.Controls.Add(this.mult);
            this.panel1.Controls.Add(this.div);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Controls.Add(this.res);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 236);
            this.panel1.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Location = new System.Drawing.Point(185, 211);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 25);
            this.clear.TabIndex = 7;
            this.clear.Text = "Limpar";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // rest
            // 
            this.rest.AutoSize = true;
            this.rest.Location = new System.Drawing.Point(211, 181);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(0, 17);
            this.rest.TabIndex = 10;
            // 
            // mult
            // 
            this.mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mult.Location = new System.Drawing.Point(150, 119);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(28, 28);
            this.mult.TabIndex = 5;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.div.Location = new System.Drawing.Point(214, 119);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(28, 28);
            this.div.TabIndex = 6;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sub
            // 
            this.sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub.Location = new System.Drawing.Point(84, 119);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(28, 28);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
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
            this.text2.TabIndex = 2;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(135, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(116, 23);
            this.text1.TabIndex = 1;
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
            // sum
            // 
            this.sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum.Location = new System.Drawing.Point(18, 119);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(28, 28);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(290, 263);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Label rest;
        private System.Windows.Forms.Button clear;
    }
}