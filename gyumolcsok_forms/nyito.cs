using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gyumolcs_adatbazis;
using MySql.Data.MySqlClient;

namespace gyumolcsok_forms
{
    public partial class Form_nyito : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        
        public Form_nyito()
        {
            InitializeComponent();
        }
        public void gyumolcs_list_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok`";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("Id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    list_adatok.Items.Add(uj);
                }
            }
            connect.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            connect = new MySqlConnection(builder.ConnectionString);
            try
            {
                //terv szerint
                connect.Open();
                cmd = connect.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //terv megbukott
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leált");
                Environment.Exit(0);
            }
            finally
            {
                connect.Close();
            }
            gyumolcs_list_update();
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formgyumolcs_new.ShowDialog();
            gyumolcs_list_update();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formgyumolcs_edit.ShowDialog();
            gyumolcs_list_update();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formgyumolcs_delete.ShowDialog();
            gyumolcs_list_update();
        }

        private void list_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                return;
            }
            gyumolcs kivalasztott_gyumolcs = (gyumolcs)list_adatok.SelectedItem;
            textBox1_id.Text = kivalasztott_gyumolcs.Id.ToString();
            textBox1_nev.Text = kivalasztott_gyumolcs.Nev;
            numericUpDown1_egysegar.Value = Convert.ToDecimal(kivalasztott_gyumolcs.Egysegar);
            numericUpDown1_mennyiseg.Value = Convert.ToDecimal(kivalasztott_gyumolcs.Mennyiseg);
        }
    }
}
