using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace jatek_form
{
    public partial class Form_nyito : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public Form_nyito()
        {
            InitializeComponent();
        }
        public  void jatek_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `nev`,`jatekido`,`studio`,`osszertek` FROM `ertekeles` ";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    jatek uj = new jatek(dr.GetString("nev"), dr.GetString("jatekido"), dr.GetString("studio"), dr.GetDouble("osszertek"));
                    list_adatok.Items.Add(uj);
                }
            }
            connect.Close();
        }

        private void Form_nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "jatekok";
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
            jatek_update();
        }

        private void list_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            jatek kivalasztott_adat = (jatek)list_adatok.SelectedItem;
            textBox1_nev.Text = kivalasztott_adat.Nev.ToString();
            textBox_jatekido.Text =kivalasztott_adat.Jatekido.ToString();
            textBox_studio.Text = kivalasztott_adat.Studio.ToString() ;
            numericUpDown_ertekeles.Value = (decimal)kivalasztott_adat.Ertekeles;     

        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Rogzit.ShowDialog();
            jatek_update();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Edit.ShowDialog();
            jatek_update();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Delete.ShowDialog();
            jatek_update();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
