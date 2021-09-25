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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void adaugaTranz_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=paoo");

            String idtr = idTranz.Text;
            String idclient = idCli.Text;
            String sumap = sumaPrim.Text;
            String sumao = sumaOf.Text;
            String datatr = dataTranz.Text;
                
            MySqlDataAdapter sda = new MySqlDataAdapter("INSERT into tranzactii(idtranz,idclient,sumaprimita,sumaoferita,datatranzactiei) values ('" + idtr + "','" + idclient + "','" + sumap + "','" + sumao + "','" + datatr + "')", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Form2().Show();
        }
    }
}
