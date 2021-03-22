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
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
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
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblCategory";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbGelen.Items.Add(dr["CategoryName"]);
            }
            conn.Close();
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
