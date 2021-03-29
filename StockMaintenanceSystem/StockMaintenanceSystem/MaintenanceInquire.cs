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
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-FMSK50S; Initial Catalog = dbStock; Integrated Security = True");
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn2SorgulaTemizle_Click(object sender, EventArgs e)
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
                SorgulaEkipmanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();


        }

        private void btn2SorgulaAnasayfayadon_Click(object sender, EventArgs e)
        {
            MaintenanceSystem maintenanceSystem = new MaintenanceSystem();
            maintenanceSystem.Show();
            this.Hide();
        }

        private void MaintenanceInquire_Load(object sender, EventArgs e)
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
                SorgulaEkipmanAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();
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
            cmd.Parameters.AddWithValue("@ad", SorgulaEkipmanAdi.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void MaintenanceInquire_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış Yapılıyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();

        }
    }
}
