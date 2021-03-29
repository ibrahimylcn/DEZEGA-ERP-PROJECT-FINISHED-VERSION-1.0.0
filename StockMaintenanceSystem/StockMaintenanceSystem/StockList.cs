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
    public partial class StockList : Form
    {
        public StockList()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-FMSK50S; Initial Catalog = dbStock; Integrated Security = True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockSystem stockSystem = new StockSystem();
            stockSystem.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dbStockEntities5 se = new dbStockEntities5();
            dataGridViewTumunuListele.DataSource = se.tblEquipmentStock.ToList();
        }

        private void StockList_Load(object sender, EventArgs e)
        {

        }

        private void StockList_FormClosing(object sender, FormClosingEventArgs e)
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
