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
            dbStockEntities db = new dbStockEntities();

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
            u.NumberOfUsedObject = txtBakimKullanilanParSayisi.Text;

            db.tblMaintenance.Add(m);
            db.tblMaintnncEquipment.Add(me);
            db.tblUsedObject.Add(u);
            db.SaveChanges();
            MessageBox.Show("Bakım-Onarım başarıyla kaydedilmiştir.");
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
    }
}
