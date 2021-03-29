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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Load_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("dezega.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            timer1.Stop();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Load_FormClosing(object sender, FormClosingEventArgs e)
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
