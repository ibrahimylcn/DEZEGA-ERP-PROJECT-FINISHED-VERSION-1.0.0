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
    public partial class AddedStock : Form
    {
        public AddedStock()
        {
            InitializeComponent();
        }

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

        }

        private void btnGelenKaydet_Click(object sender, EventArgs e)
        {
            // Button Gelen Kaydet
            MessageBox.Show("İşlem Başarılı!!");
        }

        private void BtnGelenTemizle_Click(object sender, EventArgs e)
        {
            // Button Gelen Temizle
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
