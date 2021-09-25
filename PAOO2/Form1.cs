using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace PAOO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {        

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM login WHERE utilizator='" + username.Text + "' AND parola='" + password.Text + "'", con);
            
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                
                this.Hide();
                new Form2().Show();
            }
            else
                MessageBox.Show("Verificati-va numele de utilizator si/sau parola");

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
