namespace gyumolcsok_forms
{
    partial class form_new
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
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_egysegar = new System.Windows.Forms.NumericUpDown();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.button_rogz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_mennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(387, 126);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.ReadOnly = true;
            this.textBox1_id.Size = new System.Drawing.Size(84, 20);
            this.textBox1_id.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Id:";
            // 
            // numericUpDown1_mennyiseg
            // 
            this.numericUpDown1_mennyiseg.DecimalPlaces = 2;
            this.numericUpDown1_mennyiseg.Location = new System.Drawing.Point(388, 238);
            this.numericUpDown1_mennyiseg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1_mennyiseg.Name = "numericUpDown1_mennyiseg";
            this.numericUpDown1_mennyiseg.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_mennyiseg.TabIndex = 40;
            // 
            // numericUpDown1_egysegar
            // 
            this.numericUpDown1_egysegar.DecimalPlaces = 2;
            this.numericUpDown1_egysegar.Location = new System.Drawing.Point(388, 198);
            this.numericUpDown1_egysegar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1_egysegar.Name = "numericUpDown1_egysegar";
            this.numericUpDown1_egysegar.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_egysegar.TabIndex = 39;
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(387, 165);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(84, 20);
            this.textBox1_nev.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Egységár:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Neve:";
            // 
            // list_adatok
            // 
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 0);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 450);
            this.list_adatok.TabIndex = 34;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // button_rogz
            // 
            this.button_rogz.Location = new System.Drawing.Point(348, 283);
            this.button_rogz.Name = "button_rogz";
            this.button_rogz.Size = new System.Drawing.Size(106, 31);
            this.button_rogz.TabIndex = 43;
            this.button_rogz.Text = "Rögzítés";
            this.button_rogz.UseVisualStyleBackColor = true;
            this.button_rogz.Click += new System.EventHandler(this.button_rogz_Click);
            // 
            // form_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_rogz);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1_mennyiseg);
            this.Controls.Add(this.numericUpDown1_egysegar);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_adatok);
            this.Name = "form_new";
            this.Text = "new";
            this.Load += new System.EventHandler(this.form_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_mennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egysegar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1_mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown1_egysegar;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.Button button_rogz;
    }
}