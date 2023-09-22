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

namespace vizsgaremek
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            MySqlCommand cmd = new MySqlCommand("insert into rendeles value(@rendeles_id,@user_id,@skin_id,@datum,@osszeg)", mySqlConnection);

            mySqlConnection.Open();
            cmd.Parameters.AddWithValue("@rendeles_id", int.Parse(rendeles_id_tb.Text));
            cmd.Parameters.AddWithValue("@user_id", int.Parse(user_id_tb.Text));
            cmd.Parameters.AddWithValue("@skin_id", int.Parse(skin_id_tb.Text));
            cmd.Parameters.AddWithValue("@datum", (datum_tb.Text));
            cmd.Parameters.AddWithValue("@osszeg", int.Parse(osszeg_tb.Text));
            cmd.ExecuteNonQuery();


            mySqlConnection.Close();
            MessageBox.Show("Sikeresen mentve!");




        }

        private void update_brn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand("update rendeles set user_id=@user_id, skin_id=@skin_id, datum=@datum, osszeg=@osszeg WHERE rendeles_id = " + rendeles_id_tb.Text, mySqlConnection);
            //cmd.Parameters.AddWithValue("@rendeles_id", int.Parse(rendeles_id_tb.Text));
            cmd.Parameters.AddWithValue("@user_id", int.Parse(user_id_tb.Text));
            cmd.Parameters.AddWithValue("@skin_id", int.Parse(skin_id_tb.Text));
            cmd.Parameters.AddWithValue("@datum", (datum_tb.Text));
            cmd.Parameters.AddWithValue("@osszeg", int.Parse(osszeg_tb.Text));
            cmd.ExecuteNonQuery();


            mySqlConnection.Close();
            MessageBox.Show("Sikeresen átírva!");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
            mySqlConnection.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM rendeles WHERE rendeles_id=@rendeles_id", mySqlConnection);
            cmd.Parameters.AddWithValue("@rendeles_id", int.Parse(rendeles_id_tb.Text));
            cmd.ExecuteNonQuery();

            mySqlConnection.Close();
            MessageBox.Show("Sikeres törlés!");

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (rendeles_id_tb.Text == "")
            {

                string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("Select * from rendeles", mySqlConnection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

                string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);
                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("Select * from rendeles where rendeles_id=@rendeles_id", mySqlConnection);
                cmd.Parameters.AddWithValue("@rendeles_id", int.Parse(rendeles_id_tb.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            rendeles_id_tb.Clear();
            user_id_tb.Clear();
            skin_id_tb.Clear();
            datum_tb.Clear();
            osszeg_tb.Clear();
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
