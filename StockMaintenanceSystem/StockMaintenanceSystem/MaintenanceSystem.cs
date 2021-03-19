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
            MessageBox.Show("İşlem Başarılı!!");
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
