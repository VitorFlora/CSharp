namespace HelloWorld
{
    partial class Imc
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_imc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result_imc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.Label();
            this.btn_mal = new System.Windows.Forms.Button();
            this.btn_n = new System.Windows.Forms.Button();
            this.btn_fem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.num_imc);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.result_imc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cal);
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.btn_mal);
            this.panel1.Controls.Add(this.btn_n);
            this.panel1.Controls.Add(this.btn_fem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text2);
            this.panel1.Controls.Add(this.text1);
            this.panel1.Controls.Add(this.lb3);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 297);
            this.panel1.TabIndex = 0;
            // 
            // num_imc
            // 
            this.num_imc.AutoSize = true;
            this.num_imc.Location = new System.Drawing.Point(192, 180);
            this.num_imc.Name = "num_imc";
            this.num_imc.Size = new System.Drawing.Size(0, 13);
            this.num_imc.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result_imc
            // 
            this.result_imc.AutoSize = true;
            this.result_imc.Location = new System.Drawing.Point(93, 221);
            this.result_imc.Name = "result_imc";
            this.result_imc.Size = new System.Drawing.Size(0, 13);
            this.result_imc.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "IMC:";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(94, 267);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 14;
            this.cal.Text = "Calcular";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(196, 155);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(0, 13);
            this.sex.TabIndex = 13;
            // 
            // btn_mal
            // 
            this.btn_mal.BackgroundImage = global::HelloWorld.Properties.Resources.male;
            this.btn_mal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mal.Location = new System.Drawing.Point(68, 6);
            this.btn_mal.Name = "btn_mal";
            this.btn_mal.Size = new System.Drawing.Size(60, 102);
            this.btn_mal.TabIndex = 12;
            this.btn_mal.UseVisualStyleBackColor = true;
            this.btn_mal.Click += new System.EventHandler(this.btn_mal_Click);
            // 
            // btn_n
            // 
            this.btn_n.BackgroundImage = global::HelloWorld.Properties.Resources.questionMark;
            this.btn_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_n.Location = new System.Drawing.Point(134, 6);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(60, 102);
            this.btn_n.TabIndex = 11;
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.btn_n_Click);
            // 
            // btn_fem
            // 
            this.btn_fem.BackgroundImage = global::HelloWorld.Properties.Resources.female;
            this.btn_fem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fem.Location = new System.Drawing.Point(202, 6);
            this.btn_fem.Name = "btn_fem";
            this.btn_fem.Size = new System.Drawing.Size(60, 102);
            this.btn_fem.TabIndex = 10;
            this.btn_fem.UseVisualStyleBackColor = true;
            this.btn_fem.Click += new System.EventHandler(this.btn_fem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sexo:";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(73, 177);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(70, 20);
            this.text2.TabIndex = 8;
            // 
            // text1
            // 
            this.text1.AccessibleDescription = "";
            this.text1.Location = new System.Drawing.Point(73, 151);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(70, 20);
            this.text1.TabIndex = 7;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(18, 178);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(44, 17);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "Peso:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(18, 152);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(49, 17);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Altura:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(18, 45);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(43, 17);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "Sexo:";
            // 
            // Imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.panel1);
            this.Name = "Imc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imc";
            this.Load += new System.EventHandler(this.Imc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btn_mal;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Button btn_fem;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result_imc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label num_imc;
    }
}