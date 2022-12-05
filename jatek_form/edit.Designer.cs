namespace jatek_form
{
    partial class form_edit
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
            this.textBox_jatekido = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.textBox_studio = new System.Windows.Forms.TextBox();
            this.label_studio = new System.Windows.Forms.Label();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.numericUpDown_ertekeles = new System.Windows.Forms.NumericUpDown();
            this.label_ertekeles = new System.Windows.Forms.Label();
            this.label_jatekido = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_jatekido
            // 
            this.textBox_jatekido.Location = new System.Drawing.Point(591, 132);
            this.textBox_jatekido.Name = "textBox_jatekido";
            this.textBox_jatekido.Size = new System.Drawing.Size(97, 20);
            this.textBox_jatekido.TabIndex = 68;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(447, 271);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(127, 38);
            this.edit.TabIndex = 67;
            this.edit.Text = "Módosítás";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // textBox_studio
            // 
            this.textBox_studio.Location = new System.Drawing.Point(376, 191);
            this.textBox_studio.Name = "textBox_studio";
            this.textBox_studio.Size = new System.Drawing.Size(108, 20);
            this.textBox_studio.TabIndex = 66;
            // 
            // label_studio
            // 
            this.label_studio.AutoSize = true;
            this.label_studio.Location = new System.Drawing.Point(330, 194);
            this.label_studio.Name = "label_studio";
            this.label_studio.Size = new System.Drawing.Size(40, 13);
            this.label_studio.TabIndex = 65;
            this.label_studio.Text = "Stúdió:";
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(376, 132);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(108, 20);
            this.textBox1_nev.TabIndex = 64;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(340, 135);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 63;
            this.label_nev.Text = "Név:";
            // 
            // numericUpDown_ertekeles
            // 
            this.numericUpDown_ertekeles.DecimalPlaces = 2;
            this.numericUpDown_ertekeles.Location = new System.Drawing.Point(591, 191);
            this.numericUpDown_ertekeles.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_ertekeles.Name = "numericUpDown_ertekeles";
            this.numericUpDown_ertekeles.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_ertekeles.TabIndex = 62;
            // 
            // label_ertekeles
            // 
            this.label_ertekeles.AutoSize = true;
            this.label_ertekeles.Location = new System.Drawing.Point(534, 194);
            this.label_ertekeles.Name = "label_ertekeles";
            this.label_ertekeles.Size = new System.Drawing.Size(51, 13);
            this.label_ertekeles.TabIndex = 61;
            this.label_ertekeles.Text = "Értékelés";
            // 
            // label_jatekido
            // 
            this.label_jatekido.AutoSize = true;
            this.label_jatekido.Location = new System.Drawing.Point(538, 137);
            this.label_jatekido.Name = "label_jatekido";
            this.label_jatekido.Size = new System.Drawing.Size(50, 13);
            this.label_jatekido.TabIndex = 60;
            this.label_jatekido.Text = "Játékidő:";
            // 
            // list_adatok
            // 
            this.list_adatok.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 0);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 450);
            this.list_adatok.TabIndex = 59;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_jatekido);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.textBox_studio);
            this.Controls.Add(this.label_studio);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.numericUpDown_ertekeles);
            this.Controls.Add(this.label_ertekeles);
            this.Controls.Add(this.label_jatekido);
            this.Controls.Add(this.list_adatok);
            this.Name = "form_edit";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.form_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_jatekido;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox textBox_studio;
        private System.Windows.Forms.Label label_studio;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_ertekeles;
        private System.Windows.Forms.Label label_ertekeles;
        private System.Windows.Forms.Label label_jatekido;
        private System.Windows.Forms.ListBox list_adatok;
    }
}