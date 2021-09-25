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
using System.Windows.Forms.VisualStyles;

namespace PAOO2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adaugaClient_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Form3().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paooDataSet.clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.paooDataSet.clienti);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void stergeClient_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            MySqlDataAdapter sda = new MySqlDataAdapter("DELETE FROM clienti where idclient = '"+ index +"'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
           

        }

        private void ActualizareClienti_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM clienti", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void actualizeazaTranz_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tranzactii", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void stergeTranzactie_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }

            var index = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);


            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            MySqlDataAdapter sda = new MySqlDataAdapter("DELETE FROM tranzactii where idtranz = '" + index + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        private void adaugaTranzactie_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Form4().Show();
        }

        private void Delogare_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void cautare_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            String numecli = cautarenumecli.Text;
           

            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from clienti where nume_cli = '" + numecli + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void cautareidcli_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            String idcli = cautareidcl.Text;


            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from tranzactii where idclient = '" + idcli + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

        }
    }
}
