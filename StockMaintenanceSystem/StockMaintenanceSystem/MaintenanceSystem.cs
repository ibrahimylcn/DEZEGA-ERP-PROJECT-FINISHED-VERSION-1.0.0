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
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
        private void btnBakimKaydet_Click(object sender, EventArgs e)
        {
            if (txtBakimBasSaati.Text == " " || txtBakimBitisSaati.Text == " " || txtBakimEkimpanKodu.Text == " " || txtBakimEkipmanAdi.Text == " " || txtBakimKisiSayisi.Text == " " || dateTimeBakimBaslangic.Text == " " || dateTimeBakimBitis.Text == " " ||  cmbBakimİsTürü.Text == " " ||
                txtBakimBasSaati.Text == String.Empty || txtBakimBitisSaati.Text == String.Empty || txtBakimEkimpanKodu.Text == String.Empty || txtBakimEkipmanAdi.Text == String.Empty || txtBakimKisiSayisi.Text == String.Empty || dateTimeBakimBaslangic.Text == String.Empty || dateTimeBakimBitis.Text  == String.Empty || cmbBakimİsTürü.Text == String.Empty)
            {
                MessageBox.Show("Lütfen (*) Alan Bilgilerini Doldurunuz!!");
            }
            else
            {
                dbStockEntities4 db = new dbStockEntities4();
                tblMaintenance m = new tblMaintenance
                {
                    StartingDate = dateTimeBakimBaslangic.Text,
                    StartTime = txtBakimBasSaati.Text,
                    DueDate = dateTimeBakimBitis.Text,
                    EndTime = txtBakimBitisSaati.Text,

                    JobType = cmbBakimİsTürü.Text
                };


                tblMaintnncEquipment me = new tblMaintnncEquipment();

                me.mEquipmentCode = txtBakimEkimpanKodu.Text;
                me.mEquipmentName = txtBakimEkipmanAdi.Text;
                me.mNumberOfEquipment = txtBakimKisiSayisi.Text;

                tblUsedObject u = new tblUsedObject();

                u.UsedObjectCode = txtBakimKullanilanParKodu.Text;
                u.UsedObjectName = txtBakimKullanilanParAdi.Text;
                //u.NumberOfUsedObject = Convert.ToInt32(txtBakimKullanilanParSayisi.Text);

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
        }

        private void btnBakimAnasayfa_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void btnBakimCikis_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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

            SqlCommand cmd = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblCategory";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader drr;
            conn.Open();
            drr = komut.ExecuteReader();
            while (drr.Read())
            {
                cmbBakimİsTürü.Items.Add(drr["CategoryName"]);
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
    }
}
