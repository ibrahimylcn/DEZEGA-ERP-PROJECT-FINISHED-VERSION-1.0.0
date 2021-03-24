using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaintenanceSystem
{
    public partial class MaintenanceSystem : Form
    {
        public MaintenanceSystem()
        {
            InitializeComponent();
        }

        private void btnBakimKaydet_Click(object sender, EventArgs e)
        {
            if (txtBakimBasSaati.Text == " " || txtBakimBitisSaati.Text == " " || txtBakimEkimpanKodu.Text == " " || txtBakimEkipmanAdi.Text == " " || txtBakimKisiSayisi.Text == " " || txtBakimKullanilanParAdi.Text == " " ||  txtBakimKullanilanParKodu.Text == " " || txtBakimKullanilanParSayisi.Text == " " || dateTimeBakimBaslangic.Text == " " || dateTimeBakimBitis.Text == " " || cmbBakimİletimYolu.Text == " " || cmbBakımIsalani.Text == " " || cmbBakimİsTürü.Text == " " ||
                txtBakimBasSaati.Text == String.Empty || txtBakimBitisSaati.Text == String.Empty || txtBakimEkimpanKodu.Text == String.Empty || txtBakimEkipmanAdi.Text == String.Empty || txtBakimKisiSayisi.Text == String.Empty || txtBakimKullanilanParAdi.Text == String.Empty || txtBakimKullanilanParKodu.Text == String.Empty || txtBakimKullanilanParSayisi.Text == String.Empty || dateTimeBakimBaslangic.Text == String.Empty || dateTimeBakimBitis.Text == String.Empty || cmbBakimİletimYolu.Text == String.Empty || cmbBakımIsalani.Text == String.Empty || cmbBakimİsTürü.Text == String.Empty)
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Doldurunuz!!");
            }
            else
            {
                dbStockEntities3 db = new dbStockEntities3();
                tblMaintenance m = new tblMaintenance();

                m.StartingDate = dateTimeBakimBaslangic.Text;
                m.StartTime = txtBakimBasSaati.Text;
                m.DueDate = dateTimeBakimBitis.Text;
                m.EndTime = txtBakimBitisSaati.Text;
                m.BusinessArea = cmbBakımIsalani.Text;
                m.JobType = cmbBakimİsTürü.Text;
                m.TransmissionRoot = cmbBakimİletimYolu.Text;

                tblMaintnncEquipment me = new tblMaintnncEquipment();

                me.mEquipmentCode = txtBakimEkimpanKodu.Text;
                me.mEquipmentName = txtBakimEkipmanAdi.Text;
                me.mNumberOfEquipment = txtBakimKisiSayisi.Text;

                tblUsedObject u = new tblUsedObject();

                u.UsedObjectCode = txtBakimKullanilanParKodu.Text;
                u.UsedObjectName = txtBakimKullanilanParAdi.Text;
                u.NumberOfUsedObject = Convert.ToInt32(txtBakimKullanilanParSayisi.Text);

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
    }
}
