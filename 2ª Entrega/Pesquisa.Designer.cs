namespace HelloWorld
{
    partial class Pesquisa
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btListar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "[Digite aqui]";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 121);
            this.listBox1.TabIndex = 1;
            // 
            // btListar
            // 
            this.btListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btListar.Location = new System.Drawing.Point(186, 4);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 34);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pesquisa Simples";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisa Otimizada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 192);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(411, 20);
            this.txt2.TabIndex = 5;
            this.txt2.Text = "[Insira um nome válido]";
            this.txt2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt1);
            this.Name = "Pesquisa";
            this.Text = "Pesquisa Dinâmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt2;
    }
}