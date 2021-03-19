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
    public partial class MaintenanceInquire : Form
    {
        public MaintenanceInquire()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn2SorgulaTemizle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btn2SorgulaAnasayfayadon_Click(object sender, EventArgs e)
        {
            MaintenanceSystem maintenanceSystem = new MaintenanceSystem();
            maintenanceSystem.Show();
            this.Hide();
        }
    }
}
