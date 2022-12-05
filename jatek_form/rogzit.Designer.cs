namespace jatek_form
{
    partial class form_rogzit
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
            this.textBox_studio = new System.Windows.Forms.TextBox();
            this.label_studio = new System.Windows.Forms.Label();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.numericUpDown_ertekeles = new System.Windows.Forms.NumericUpDown();
            this.label_ertekeles = new System.Windows.Forms.Label();
            this.label_jatekido = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.rogzit = new System.Windows.Forms.Button();
            this.textBox_jatekido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_studio
            // 
            this.textBox_studio.Location = new System.Drawing.Point(264, 191);
            this.textBox_studio.Name = "textBox_studio";
            this.textBox_studio.Size = new System.Drawing.Size(108, 20);
            this.textBox_studio.TabIndex = 55;
            // 
            // label_studio
            // 
            this.label_studio.AutoSize = true;
            this.label_studio.Location = new System.Drawing.Point(218, 194);
            this.label_studio.Name = "label_studio";
            this.label_studio.Size = new System.Drawing.Size(40, 13);
            this.label_studio.TabIndex = 54;
            this.label_studio.Text = "Stúdió:";
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(264, 132);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(108, 20);
            this.textBox1_nev.TabIndex = 53;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(228, 135);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 52;
            this.label_nev.Text = "Név:";
            // 
            // numericUpDown_ertekeles
            // 
            this.numericUpDown_ertekeles.DecimalPlaces = 2;
            this.numericUpDown_ertekeles.Location = new System.Drawing.Point(479, 191);
            this.numericUpDown_ertekeles.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_ertekeles.Name = "numericUpDown_ertekeles";
            this.numericUpDown_ertekeles.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_ertekeles.TabIndex = 51;
            // 
            // label_ertekeles
            // 
            this.label_ertekeles.AutoSize = true;
            this.label_ertekeles.Location = new System.Drawing.Point(422, 194);
            this.label_ertekeles.Name = "label_ertekeles";
            this.label_ertekeles.Size = new System.Drawing.Size(51, 13);
            this.label_ertekeles.TabIndex = 50;
            this.label_ertekeles.Text = "Értékelés";
            // 
            // label_jatekido
            // 
            this.label_jatekido.AutoSize = true;
            this.label_jatekido.Location = new System.Drawing.Point(426, 137);
            this.label_jatekido.Name = "label_jatekido";
            this.label_jatekido.Size = new System.Drawing.Size(50, 13);
            this.label_jatekido.TabIndex = 49;
            this.label_jatekido.Text = "Játékidő:";
            // 
            // list_adatok
            // 
            this.list_adatok.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 0);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 443);
            this.list_adatok.TabIndex = 48;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // rogzit
            // 
            this.rogzit.Location = new System.Drawing.Point(335, 271);
            this.rogzit.Name = "rogzit";
            this.rogzit.Size = new System.Drawing.Size(127, 38);
            this.rogzit.TabIndex = 57;
            this.rogzit.Text = "Rögzít";
            this.rogzit.UseVisualStyleBackColor = true;
            this.rogzit.Click += new System.EventHandler(this.rogzit_Click);
            // 
            // textBox_jatekido
            // 
            this.textBox_jatekido.Location = new System.Drawing.Point(479, 132);
            this.textBox_jatekido.Name = "textBox_jatekido";
            this.textBox_jatekido.Size = new System.Drawing.Size(97, 20);
            this.textBox_jatekido.TabIndex = 58;
            // 
            // form_rogzit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 443);
            this.Controls.Add(this.textBox_jatekido);
            this.Controls.Add(this.rogzit);
            this.Controls.Add(this.textBox_studio);
            this.Controls.Add(this.label_studio);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.numericUpDown_ertekeles);
            this.Controls.Add(this.label_ertekeles);
            this.Controls.Add(this.label_jatekido);
            this.Controls.Add(this.list_adatok);
            this.Name = "form_rogzit";
            this.Text = "rogzit";
            this.Load += new System.EventHandler(this.form_rogzit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_studio;
        private System.Windows.Forms.Label label_studio;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_ertekeles;
        private System.Windows.Forms.Label label_ertekeles;
        private System.Windows.Forms.Label label_jatekido;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.Button rogzit;
        private System.Windows.Forms.TextBox textBox_jatekido;
    }
}