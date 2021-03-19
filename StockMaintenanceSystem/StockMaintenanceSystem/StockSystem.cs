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
    public partial class StockSystem : Form
    {
        public StockSystem()
        {
            InitializeComponent();
        }

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
            // Button Yeni Kaydet
            MessageBox.Show("İşlem Başarılı!!");
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

        }
    }
}
