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
    public partial class MaintenanceList : Form
    {
        public MaintenanceList()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-0RNQ9SP\MSSQLSERVER01; Initial Catalog = dbStock; Integrated Security = True");
        dbStockEntities3 me = new dbStockEntities3();
        private void btnBakımListele_Click(object sender, EventArgs e)
        {
            var list = from x in me.tblMaintenance join y in me.tblMaintnncEquipment
                       on x.MaintenanceID equals y.mEquipmentID join z in me.tblUsedObject on
                       x.MaintenanceID equals z.UsedObjectID
                       select new {
                           x.MaintenanceID,
                           x.StartingDate,
                           x.StartTime,
                           x.DueDate,
                           x.EndTime,
                           x.TransmissionRoot,
                           x.BusinessArea,
                           x.JobType,
                           y.mEquipmentID,
                           y.mEquipmentCode,
                           y.mEquipmentName,
                           y.mNumberOfEquipment,
                           z.UsedObjectID,
                           z.UsedObjectName,
                           z.UsedObjectCode,
                           z.NumberOfUsedObject
                       };
            dataGridViewBakimListele.DataSource = list.ToList();
        }

        private void btnLBakimAnasayfaDon_Click(object sender, EventArgs e)
        {
            MaintenanceSystem maintenanceSystem = new MaintenanceSystem();
            maintenanceSystem.Show();
            this.Hide();
        }
    }
}
