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
    public partial class Inquire : Form
    {
        public Inquire()
        {
            InitializeComponent();
        }

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
    }
}
