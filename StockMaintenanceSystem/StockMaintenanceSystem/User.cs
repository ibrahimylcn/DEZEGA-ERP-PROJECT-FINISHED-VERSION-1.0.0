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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-0RNQ9SP\MSSQLSERVER01; Initial Catalog = dbStock; Integrated Security = True");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from tblUser u where u.Admin=@u1 and u.Password=@u2", conn);
            komut.Parameters.AddWithValue("@u1", txtuser.Text );
            komut.Parameters.AddWithValue("@u2", txtpswd.Text );
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                Homepage hp = new Homepage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunmamaktadır.");
            }
            conn.Close();


        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void lblpswd_Click(object sender, EventArgs e)
        {

        }
    }
}
