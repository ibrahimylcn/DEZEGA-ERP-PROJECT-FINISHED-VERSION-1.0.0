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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StockSystem ss = new StockSystem();
            ss.Show();
            this.Hide();
        }

        private void btnBakımTakip_Click(object sender, EventArgs e)
        {
            MaintenanceSystem ms = new MaintenanceSystem();
            ms.Show();
            this.Hide();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
           
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
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
