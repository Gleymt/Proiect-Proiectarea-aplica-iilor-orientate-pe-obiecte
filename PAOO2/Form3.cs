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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            String id = idcli.Text;
            String nume = numecli.Text;
            String prenume = prenumecli.Text;
            String cnp = cnpcli.Text;
            String serie = seriecli.Text;

            MySqlDataAdapter sda = new MySqlDataAdapter("INSERT into clienti(idclient,nume_cli,prenume_cli,cnp_cli,serie_cli) values ('"+ id + "','" + nume + "','" + prenume + "','" + cnp + "','" + serie + "')", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           // new Form2().Show();
        }
    }
}
