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
    public partial class Inquire : Form
    {
        public Inquire() 
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-F1FAI6Q\SQLEXPRESS; Initial Catalog = dbStock; Integrated Security = True");
        private void btnSorgulaAnasayfayadon_Click(object sender, EventArgs e)
        {
            StockSystem sS = new StockSystem();
            sS.Show();
            this.Hide();
        }

        private void btnSorgulaTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Inquire_Load(object sender, EventArgs e)
        {

        }

        private void txtSorgulaEkipmanKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSorgulaSorgula_Click(object sender, EventArgs e)
        {
            dbStockEntities se = new dbStockEntities();
            dataGridView1.DataSource = se.tblEquipmentStock.ToList();
        }
    }
}
