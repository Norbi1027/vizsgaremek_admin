using MySql.Data.MySqlClient;
using System;
using System.Drawing.Text;

namespace vizsgaremek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string sql;
        private void login_Click(object sender, EventArgs e)
        {

            string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string username = username_textbox.Text.ToString();
            string password = password_textbox.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("üres mezõ!");
            }
            else
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select * from login_test", mySqlConnection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                    {

                        Dashboard dsb = new Dashboard();
                        Form1 form1 = new Form1();
                        dsb.Show();
                        form1.Close();
                        MessageBox.Show("Belépés sikeres!");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen bejelentkezés!");
                        break;
                    }

                }
                mySqlConnection.Close();
            }



        }
    }
}