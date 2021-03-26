using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockMaintenanceSystem
{
    public partial class Inquire : Form
    {
        public Inquire() 
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-0RNQ9SP\MSSQLSERVER01; Initial Catalog = dbStock; Integrated Security = True");
        private void btnSorgulaAnasayfayadon_Click(object sender, EventArgs e)
        {
            StockSystem sS = new StockSystem();
            sS.Show();
            this.Hide();
        }

        private void btnSorgulaTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT *FROM tblEquipmentStock",
                Connection = conn,
                CommandType = CommandType.Text
            };

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbSorgulaEkipmanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();
        }

        private void Inquire_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT *FROM tblEquipmentStock";
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbSorgulaEkipmanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();
        }

        private void txtSorgulaEkipmanKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSorgulaSorgula_Click(object sender, EventArgs e)
        {
            conn.Open();

            string kayit = "SELECT * from tblEquipmentStock where EquipmentName=@ad";
            SqlCommand cmd = new SqlCommand(kayit, conn);
            cmd.Parameters.AddWithValue("@ad", cmbSorgulaEkipmanAdi.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        } 
    }
}
