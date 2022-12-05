namespace jatek_form
{
    partial class Form_nyito
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
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.numericUpDown_ertekeles = new System.Windows.Forms.NumericUpDown();
            this.label_ertekeles = new System.Windows.Forms.Label();
            this.label_jatekido = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rögzítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_studio = new System.Windows.Forms.Label();
            this.textBox_studio = new System.Windows.Forms.TextBox();
            this.textBox_jatekido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(183, 132);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.ReadOnly = true;
            this.textBox1_nev.Size = new System.Drawing.Size(108, 20);
            this.textBox1_nev.TabIndex = 43;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(147, 135);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 42;
            this.label_nev.Text = "Név:";
            // 
            // numericUpDown_ertekeles
            // 
            this.numericUpDown_ertekeles.DecimalPlaces = 2;
            this.numericUpDown_ertekeles.Location = new System.Drawing.Point(401, 191);
            this.numericUpDown_ertekeles.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_ertekeles.Name = "numericUpDown_ertekeles";
            this.numericUpDown_ertekeles.ReadOnly = true;
            this.numericUpDown_ertekeles.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_ertekeles.TabIndex = 41;
            // 
            // label_ertekeles
            // 
            this.label_ertekeles.AutoSize = true;
            this.label_ertekeles.Location = new System.Drawing.Point(341, 194);
            this.label_ertekeles.Name = "label_ertekeles";
            this.label_ertekeles.Size = new System.Drawing.Size(51, 13);
            this.label_ertekeles.TabIndex = 38;
            this.label_ertekeles.Text = "Értékelés";
            // 
            // label_jatekido
            // 
            this.label_jatekido.AutoSize = true;
            this.label_jatekido.Location = new System.Drawing.Point(324, 137);
            this.label_jatekido.Name = "label_jatekido";
            this.label_jatekido.Size = new System.Drawing.Size(71, 13);
            this.label_jatekido.TabIndex = 36;
            this.label_jatekido.Text = "Játékidő(óra):";
            // 
            // list_adatok
            // 
            this.list_adatok.BackColor = System.Drawing.SystemColors.MenuBar;
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 24);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 427);
            this.list_adatok.TabIndex = 35;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rögzítésToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rögzítésToolStripMenuItem
            // 
            this.rögzítésToolStripMenuItem.Name = "rögzítésToolStripMenuItem";
            this.rögzítésToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rögzítésToolStripMenuItem.Text = "Rögzítés";
            this.rögzítésToolStripMenuItem.Click += new System.EventHandler(this.rögzítésToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // label_studio
            // 
            this.label_studio.AutoSize = true;
            this.label_studio.Location = new System.Drawing.Point(137, 194);
            this.label_studio.Name = "label_studio";
            this.label_studio.Size = new System.Drawing.Size(40, 13);
            this.label_studio.TabIndex = 45;
            this.label_studio.Text = "Stúdió:";
            // 
            // textBox_studio
            // 
            this.textBox_studio.Location = new System.Drawing.Point(183, 191);
            this.textBox_studio.Name = "textBox_studio";
            this.textBox_studio.ReadOnly = true;
            this.textBox_studio.Size = new System.Drawing.Size(108, 20);
            this.textBox_studio.TabIndex = 46;
            // 
            // textBox_jatekido
            // 
            this.textBox_jatekido.Location = new System.Drawing.Point(401, 134);
            this.textBox_jatekido.Name = "textBox_jatekido";
            this.textBox_jatekido.ReadOnly = true;
            this.textBox_jatekido.Size = new System.Drawing.Size(97, 20);
            this.textBox_jatekido.TabIndex = 59;
            // 
            // Form_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(562, 451);
            this.Controls.Add(this.textBox_jatekido);
            this.Controls.Add(this.textBox_studio);
            this.Controls.Add(this.label_studio);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.numericUpDown_ertekeles);
            this.Controls.Add(this.label_ertekeles);
            this.Controls.Add(this.label_jatekido);
            this.Controls.Add(this.list_adatok);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_nyito";
            this.Text = "Nyitó";
            this.Load += new System.EventHandler(this.Form_nyito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_ertekeles;
        private System.Windows.Forms.Label label_ertekeles;
        private System.Windows.Forms.Label label_jatekido;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rögzítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.Label label_studio;
        private System.Windows.Forms.TextBox textBox_studio;
        private System.Windows.Forms.TextBox textBox_jatekido;
    }
}

