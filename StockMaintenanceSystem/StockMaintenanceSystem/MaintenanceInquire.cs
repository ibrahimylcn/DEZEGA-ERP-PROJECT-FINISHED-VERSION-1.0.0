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
    public partial class MaintenanceInquire : Form
    {
        public MaintenanceInquire()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn2SorgulaTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btn2SorgulaAnasayfayadon_Click(object sender, EventArgs e)
        {
            MaintenanceSystem maintenanceSystem = new MaintenanceSystem();
            maintenanceSystem.Show();
            this.Hide();
        }

        private void MaintenanceInquire_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeBaslangicSorgula_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn2SorgulaSorgula_Click(object sender, EventArgs e)
        {
            //conn.Open();

            //string kayit = "SELECT * from tblMaintenance where StartingDate=@tarih";
            //SqlCommand cmd = new SqlCommand(kayit, conn);
            //cmd.Parameters.AddWithValue("@tarih", dateTimeBaslangicSorgula.Text);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;
            //conn.Close();

            

            conn.Open();

            string kayit = "SELECT * From tblMaintenance m  INNER JOIN tblMaintnncEquipment me ON m.MaintenanceID = me.mEquipmentID where StartingDate=@tarih and mEquipmentName=@ad ";
            SqlCommand cmd = new SqlCommand(kayit, conn);
            cmd.Parameters.AddWithValue("@tarih", dateTimeBaslangicSorgula.Text);
            cmd.Parameters.AddWithValue("@ad", txtSorgulaEkipmanAdi.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
    }
}
