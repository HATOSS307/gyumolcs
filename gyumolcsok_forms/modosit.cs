using gyumolcs_adatbazis;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsok_forms
{
    public partial class modosit : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public modosit()
        {
            InitializeComponent();
        }
        private void gyumolcs_list_update()
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
        private void modosit_Load(object sender, EventArgs e)
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

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }
            gyumolcs kivalasztott_gyumolcs = (gyumolcs)list_adatok.SelectedItem;
            cmd.CommandText = "UPDATE `gyumolcsok` SET nev = @nev, egysegar = @egysegar , mennyiseg = @mennyiseg  WHERE id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox1_id.Text);
            cmd.Parameters.AddWithValue("@nev", textBox1_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown1_egysegar.Value);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown1_egysegar.Value);
            connect.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres");
                connect.Close();
                textBox1_id.Text = "";
                textBox1_nev.Text = "";
                numericUpDown1_egysegar.Value = numericUpDown1_egysegar.Minimum;
                numericUpDown1_mennyiseg.Value = numericUpDown1_mennyiseg.Minimum;
                gyumolcs_list_update();
            }
            else
            {
                MessageBox.Show("Az adatok Módosítása sikertelen!");

            }
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
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
