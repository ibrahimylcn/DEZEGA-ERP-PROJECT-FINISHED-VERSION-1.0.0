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
    public partial class AddedStock : Form
    {
        public AddedStock()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-FMSK50S; Initial Catalog = dbStock; Integrated Security = True");
        private void btnGelenGelen_Click(object sender, EventArgs e)
        {
            // Buton Gelen
        }

        private void btnGelenCikan_Click(object sender, EventArgs e)
        {
            // Button Gelen Çikan --> Çıkan Form
            ExtractedStock es = new ExtractedStock();
            es.Show();
            this.Hide();
        }

        private void btnGelenYeni_Click(object sender, EventArgs e)
        {
            // Gelen Yeni Butonu
            StockSystem ss = new StockSystem();
            ss.Show();
            this.Hide();
        }

        private void btnGelenSorgula_Click(object sender, EventArgs e)
        {
            // Gelen Sorgula
            Inquire inq = new Inquire();
            inq.Show();
            this.Hide();
        }

        private void btnGelenAnasayfa_Click(object sender, EventArgs e)
        {
            // Buton Gelen Anasayfa
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();

        }

        private void AddedStock_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand
            {
                CommandText = "SELECT *FROM tblCategory",
                Connection = conn,
                CommandType = CommandType.Text
            };

            SqlDataReader dr;
            conn.Open();            
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbGelen.Items.Add(dr["CategoryName"]);
            }
            conn.Close();
            
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT *FROM tblEquipmentStock";
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbGelenAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + cmbGelenAdi.Text + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                txtGelenKod.Text = read["EquipmentCode"].ToString();
                txtGelenMarkasi.Text = read["EquipmentBrand"].ToString();
                txtGelenModel.Text = read["EquipmentModel"].ToString();
                txtGelenSerino.Text = read["EquipmentSerialNumber"].ToString();


            }
            conn.Close();


        }

        private void btnGelenKaydet_Click(object sender, EventArgs e)
        {
            if (cmbGelen.Text == " " || txtGelenKod.Text == " " || cmbGelenAdi.Text == " " || txtGelenMarkasi.Text == " " || txtGelenModel.Text == " " || dTimeGelenTarih.Text == " " || txtGelenSerino.Text == " " || txtGelenAdet.Text == " " ||
                cmbGelen.Text == String.Empty || txtGelenKod.Text == String.Empty || cmbGelenAdi.Text == String.Empty || txtGelenMarkasi.Text == String.Empty || txtGelenModel.Text == String.Empty || dTimeGelenTarih.Text == String.Empty || txtGelenSerino.Text == String.Empty || txtGelenAdet.Text == String.Empty )
            {
                MessageBox.Show("Lütfen (*) Alan Bilgilerini Doldurunuz!!");
            }
            else
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("Update tblEquipmentStock set EquipmentStockNumber = EquipmentStockNumber+'" +
                                                      int.Parse(txtGelenAdet.Text) + "'where EquipmentCode='" + txtGelenKod.Text + "' ", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Gelen EKipman Kaydetme İşlemi Başarılı!!");
                    }
            

        }

        private void BtnGelenTemizle_Click(object sender, EventArgs e)
        {
            // Button Gelen Temizle
            this.Controls.Clear();
            this.InitializeComponent();



            SqlCommand komut = new SqlCommand
            {
                CommandText = "SELECT * FROM tblCategory",
                Connection = conn,
                CommandType = CommandType.Text
            };

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbGelen.Items.Add(dr["CategoryName"]);
            }
            conn.Close();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT *FROM tblEquipmentStock";
            command.Connection = conn;
            command.CommandType = CommandType.Text;

            SqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbGelenAdi.Items.Add(dataReader["EquipmentName"]);
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + cmbGelenAdi.Text + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                txtGelenKod.Text = read["EquipmentCode"].ToString();
                txtGelenMarkasi.Text = read["EquipmentBrand"].ToString();
                txtGelenModel.Text = read["EquipmentModel"].ToString();
                txtGelenSerino.Text = read["EquipmentSerialNumber"].ToString();


            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockList list = new StockList();
            list.Show();
            this.Hide();
        }

        private void cmbGelenAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + cmbGelenAdi.Text + "'",conn);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read()){

                txtGelenKod.Text = read["EquipmentCode"].ToString();
                txtGelenMarkasi.Text = read["EquipmentBrand"].ToString();
                txtGelenModel.Text = read["EquipmentModel"].ToString();
                txtGelenSerino.Text = read["EquipmentSerialNumber"].ToString();


            }
            conn.Close();


        }

        private void AddedStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış Yapılıyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();

        }

        private void cmbGelen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGelenKategori_Click(object sender, EventArgs e)
        {

        }
    }
}
