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
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-0RNQ9SP\MSSQLSERVER01; Initial Catalog = dbStock; Integrated Security = True");
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
            dbStockEntities4 se = new dbStockEntities4();
            dataGridViewTumunuListele.DataSource = se.tblEquipmentStock.ToList();
        }
    }
}
