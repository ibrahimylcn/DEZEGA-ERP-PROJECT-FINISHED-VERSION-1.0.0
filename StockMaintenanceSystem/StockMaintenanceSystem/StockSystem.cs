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
    public partial class StockSystem : Form
    {
        public StockSystem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
        private void txtYeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniCikan_Click(object sender, EventArgs e)
        {
            // Button Yeni Çıkan --> Çıkan Form
            ExtractedStock es = new ExtractedStock();
            es.Show();
            this.Hide();
        }

        private void btnYeniGelen_Click(object sender, EventArgs e)
        {
            // Button Yeni Gelen --> Gelen Form
            AddedStock added = new AddedStock();
            added.Show();
            this.Hide();
        }

        private void btnYeniSorgula_Click(object sender, EventArgs e)
        {
            // Button Yeni Sorgula
            Inquire inq = new Inquire();
            inq.Show();
            this.Hide();
        }

        private void btnYeniAnasayfa_Click(object sender, EventArgs e)
        {
            // Button Yeni Anasayfa
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            dbStockEntities db = new dbStockEntities();
            tblEquipmentStock tes = new tblEquipmentStock();
            tes.EquipmentCategory = cmbYeniKategori.Text;
            tes.EquipmentCode = txtYeniKod.Text;
            tes.EquipmentName = txtYeniAdi.Text;
            tes.EquipmentBrand = txtYeniMarkasi.Text;
            tes.EquipmentModel = txtYeniModel.Text;
            tes.EquipmentArea = txtYeniAlan.Text;
            tes.EquipmentAddedDate = dTimeYeniTarih.Text;
            tes.EquipmentSerialNumber = txtYeniSerino.Text;
            tes.EquipmentStockNumber = txtYeniAdet.Text;
            tes.EquipmentCompany = txtYeniFirma.Text;
            tes.EquipmentOrderCode = txtYeniSiparisKodu.Text;
            tes.PurposeWhy = txtYeniAmacNeden.Text;

            db.tblEquipmentStock.Add(tes);
            db.SaveChanges();
            MessageBox.Show("Yeni ekipman basariyla kaydedilmistir.");

        }

        private void BtnYeniTemizle_Click(object sender, EventArgs e)
        {
            // Button Yeni Temizle
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            // Buton Yeni
        }

        private void StockSystem_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblCategory";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbYeniKategori.Items.Add(dr["CategoryName"]);
            }
            conn.Close();
        }
    }
}
