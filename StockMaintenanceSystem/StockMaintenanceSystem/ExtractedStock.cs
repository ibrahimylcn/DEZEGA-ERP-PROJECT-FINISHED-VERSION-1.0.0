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
    public partial class ExtractedStock : Form
    {
        public ExtractedStock()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
        private void btnCikanYeni_Click(object sender, EventArgs e)
        {
            // Button Çıkan Yeni
            StockSystem ss = new StockSystem();
            ss.Show();
            this.Hide();
        }

        private void btnCikanCikan_Click(object sender, EventArgs e)
        {
            // Button Çıkan Çıkan
            /*
            AddedStock added = new AddedStock();
            added.Show();
            this.Hide(); */
        }

        private void btnCikanSorgula_Click(object sender, EventArgs e)
        {
            // Çıkan Sorgula
            Inquire inq = new Inquire();
            inq.Show();
            this.Hide();
        }

        private void btnCikanAnasayfa_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void btnCikanGelen_Click(object sender, EventArgs e)
        {
            // Button Çıkan Gelen
            AddedStock added = new AddedStock();
            added.Show();
            this.Hide();
        }

        private void btnCikanKaydet_Click(object sender, EventArgs e)
        {
          
        
        }

        private void BtnCikanTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void ExtractedStock_Load(object sender, EventArgs e)
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
                cmbCikan.Items.Add(dr["CategoryName"]);
            }
            conn.Close();
        }
    }
}
