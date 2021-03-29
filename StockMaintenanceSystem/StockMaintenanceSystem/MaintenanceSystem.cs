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
    public partial class MaintenanceSystem : Form
    {
        public MaintenanceSystem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-FMSK50S; Initial Catalog = dbStock; Integrated Security = True");
        private void btnBakimKaydet_Click(object sender, EventArgs e)
        {
            if (txtBakimBasSaati.Text == " " || txtBakimBitisSaati.Text == " " || txtBakimEkimpanKodu.Text == " " || txtBakimEkipmanAdi.Text == " " || txtBakimKisiSayisi.Text == " " || dateTimeBakimBaslangic.Text == " " || dateTimeBakimBitis.Text == " " ||  cmbBakimİsTürü.Text == " " || cmbbakimkategori.Text == " " ||
                txtBakimBasSaati.Text == String.Empty || txtBakimBitisSaati.Text == String.Empty || txtBakimEkimpanKodu.Text == String.Empty || txtBakimEkipmanAdi.Text == String.Empty || txtBakimKisiSayisi.Text == String.Empty || dateTimeBakimBaslangic.Text == String.Empty || dateTimeBakimBitis.Text  == String.Empty || cmbBakimİsTürü.Text == String.Empty || cmbbakimkategori.Text == string.Empty)
            {
                MessageBox.Show("Lütfen (*) Alan Bilgilerini Doldurunuz!!");
            }
            else
            {
                dbStockEntities5 db = new dbStockEntities5();
                tblMaintenance m = new tblMaintenance
                {
                    StartingDate = dateTimeBakimBaslangic.Text,
                    StartTime = txtBakimBasSaati.Text,
                    DueDate = dateTimeBakimBitis.Text,
                    EndTime = txtBakimBitisSaati.Text,

                    JobType = cmbBakimİsTürü.Text
                };


                tblMaintnncEquipment me = new tblMaintnncEquipment
                {
                    mEquipmentCode = txtBakimEkimpanKodu.Text,
                    mEquipmentName = txtBakimEkipmanAdi.Text,
                    mNumberOfEquipment = txtBakimKisiSayisi.Text
                };

                tblUsedObject u = new tblUsedObject
                {
                    
                    UsedObjectName = txtBakimKullanilanParAdi.Text
                };
                

                db.tblMaintenance.Add(m);
                db.tblMaintnncEquipment.Add(me);
                db.tblUsedObject.Add(u);
                db.SaveChanges();

                MessageBox.Show("Bakım-Onarım başarıyla kaydedilmiştir.");
            }            
        }

        private void btnBakimTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblEquipmentStock";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBakimEkipmanAdi.Items.Add(dr["EquipmentName"]);
            }
            conn.Close();

            SqlCommand komut2 = new SqlCommand
            {
                CommandText = "SELECT *FROM tblCategory",
                Connection = conn,
                CommandType = CommandType.Text

            };

            SqlDataReader drr;
            conn.Open();
            drr = komut2.ExecuteReader();
            while (drr.Read())
            {
                cmbbakimkategori.Items.Add(drr["CategoryName"]);
            }
            conn.Close();
        }

        private void btnBakimAnasayfa_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void btnBakimCikis_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Bakım Onarım Takip", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                MessageBox.Show("Sağlıcakla Kalın!!");
                Environment.Exit(0); // Evet tıklandığında uygulama kapanacak

            }
            else if (x == DialogResult.No)
            {
                // Hayır tıklandığında yapılacak işlemler

            }
        }

        private void MaintenanceSystem_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblEquipmentStock";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
       
        SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBakimEkipmanAdi.Items.Add(dr["EquipmentName"]);
            }
            conn.Close();

            SqlCommand komut2 = new SqlCommand
            {
                CommandText = "SELECT *FROM tblCategory",
                Connection = conn, 
                CommandType = CommandType.Text
               
            };

            SqlDataReader drr;
            conn.Open();
            drr = komut2.ExecuteReader();
            while (drr.Read())
            {
                cmbbakimkategori.Items.Add(drr["CategoryName"]);
            }
            conn.Close();
        }

        private void btn_msorgula_Click(object sender, EventArgs e)
        {
            MaintenanceInquire maintenanceInquire = new MaintenanceInquire();
            maintenanceInquire.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceList maintenanceList = new MaintenanceList();
            maintenanceList.Show();
            this.Hide();
        }

        private void txtBakimEkimpanKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBakimKisiSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBakimBasSaati_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBakimBasSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtBakimKullanilanParSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lblBakimİsTürü_Click(object sender, EventArgs e)
        {

        }

        private void MaintenanceSystem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MaintenanceSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış Yapılıyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();
        }

        private void cmbBakimİsTürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBakimEkipmanAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEquipmentStock WHERE EquipmentName like'" + txtBakimEkipmanAdi.Text + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                txtBakimEkimpanKodu.Text = read["EquipmentCode"].ToString();
                

            }
            conn.Close();
        }
    }
}
