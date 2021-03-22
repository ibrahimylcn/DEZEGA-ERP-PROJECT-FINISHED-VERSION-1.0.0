
namespace StockMaintenanceSystem
{
    partial class MaintenanceInquire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceInquire));
            this.btn2SorgulaAnasayfayaDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn2SorgulaTemizle = new System.Windows.Forms.Button();
            this.lbl2SorgulaSerino = new System.Windows.Forms.Label();
            this.btn2SorgulaSorgula = new System.Windows.Forms.Button();
            this.txtSorgulaSerino = new System.Windows.Forms.TextBox();
            this.txtSorgulaEkipmanKod = new System.Windows.Forms.TextBox();
            this.lbl2SorgulaEkipmanKodu = new System.Windows.Forms.Label();
            this.lblBakimİsTuruSorgula = new System.Windows.Forms.Label();
            this.lblBakimBaslangicTarihSorgula = new System.Windows.Forms.Label();
            this.dateTimeBaslangicSorgula = new System.Windows.Forms.DateTimePicker();
            this.cmbBakimİsTuruSorgula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2SorgulaAnasayfayaDon
            // 
            this.btn2SorgulaAnasayfayaDon.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaAnasayfayaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaAnasayfayaDon.Image")));
            this.btn2SorgulaAnasayfayaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaAnasayfayaDon.Location = new System.Drawing.Point(1182, 101);
            this.btn2SorgulaAnasayfayaDon.Name = "btn2SorgulaAnasayfayaDon";
            this.btn2SorgulaAnasayfayaDon.Size = new System.Drawing.Size(78, 41);
            this.btn2SorgulaAnasayfayaDon.TabIndex = 56;
            this.btn2SorgulaAnasayfayaDon.Text = "GERİ";
            this.btn2SorgulaAnasayfayaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaAnasayfayaDon.UseVisualStyleBackColor = true;
            this.btn2SorgulaAnasayfayaDon.Click += new System.EventHandler(this.btn2SorgulaAnasayfayadon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(985, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1245, 484);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn2SorgulaTemizle
            // 
            this.btn2SorgulaTemizle.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaTemizle.Image")));
            this.btn2SorgulaTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaTemizle.Location = new System.Drawing.Point(832, 69);
            this.btn2SorgulaTemizle.Name = "btn2SorgulaTemizle";
            this.btn2SorgulaTemizle.Size = new System.Drawing.Size(115, 48);
            this.btn2SorgulaTemizle.TabIndex = 53;
            this.btn2SorgulaTemizle.Text = "Temizle";
            this.btn2SorgulaTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaTemizle.UseVisualStyleBackColor = true;
            this.btn2SorgulaTemizle.Click += new System.EventHandler(this.btn2SorgulaTemizle_Click);
            // 
            // lbl2SorgulaSerino
            // 
            this.lbl2SorgulaSerino.AutoSize = true;
            this.lbl2SorgulaSerino.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2SorgulaSerino.Location = new System.Drawing.Point(472, 86);
            this.lbl2SorgulaSerino.Name = "lbl2SorgulaSerino";
            this.lbl2SorgulaSerino.Size = new System.Drawing.Size(112, 18);
            this.lbl2SorgulaSerino.TabIndex = 52;
            this.lbl2SorgulaSerino.Text = "Seri Numarası:";
            // 
            // btn2SorgulaSorgula
            // 
            this.btn2SorgulaSorgula.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2SorgulaSorgula.Image = ((System.Drawing.Image)(resources.GetObject("btn2SorgulaSorgula.Image")));
            this.btn2SorgulaSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2SorgulaSorgula.Location = new System.Drawing.Point(832, 14);
            this.btn2SorgulaSorgula.Name = "btn2SorgulaSorgula";
            this.btn2SorgulaSorgula.Size = new System.Drawing.Size(115, 49);
            this.btn2SorgulaSorgula.TabIndex = 51;
            this.btn2SorgulaSorgula.Text = "Sorgula";
            this.btn2SorgulaSorgula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2SorgulaSorgula.UseVisualStyleBackColor = true;
            this.btn2SorgulaSorgula.Click += new System.EventHandler(this.btn2SorgulaSorgula_Click);
            // 
            // txtSorgulaSerino
            // 
            this.txtSorgulaSerino.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorgulaSerino.Location = new System.Drawing.Point(612, 84);
            this.txtSorgulaSerino.Name = "txtSorgulaSerino";
            this.txtSorgulaSerino.Size = new System.Drawing.Size(183, 22);
            this.txtSorgulaSerino.TabIndex = 50;
            // 
            // txtSorgulaEkipmanKod
            // 
            this.txtSorgulaEkipmanKod.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorgulaEkipmanKod.Location = new System.Drawing.Point(612, 29);
            this.txtSorgulaEkipmanKod.Name = "txtSorgulaEkipmanKod";
            this.txtSorgulaEkipmanKod.Size = new System.Drawing.Size(183, 22);
            this.txtSorgulaEkipmanKod.TabIndex = 49;
            // 
            // lbl2SorgulaEkipmanKodu
            // 
            this.lbl2SorgulaEkipmanKodu.AutoSize = true;
            this.lbl2SorgulaEkipmanKodu.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2SorgulaEkipmanKodu.Location = new System.Drawing.Point(469, 31);
            this.lbl2SorgulaEkipmanKodu.Name = "lbl2SorgulaEkipmanKodu";
            this.lbl2SorgulaEkipmanKodu.Size = new System.Drawing.Size(114, 18);
            this.lbl2SorgulaEkipmanKodu.TabIndex = 48;
            this.lbl2SorgulaEkipmanKodu.Text = "Ekipman Kodu:";
            // 
            // lblBakimİsTuruSorgula
            // 
            this.lblBakimİsTuruSorgula.AutoSize = true;
            this.lblBakimİsTuruSorgula.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakimİsTuruSorgula.Location = new System.Drawing.Point(45, 84);
            this.lblBakimİsTuruSorgula.Name = "lblBakimİsTuruSorgula";
            this.lblBakimİsTuruSorgula.Size = new System.Drawing.Size(62, 18);
            this.lblBakimİsTuruSorgula.TabIndex = 57;
            this.lblBakimİsTuruSorgula.Text = "İş Türü:";
            // 
            // lblBakimBaslangicTarihSorgula
            // 
            this.lblBakimBaslangicTarihSorgula.AutoSize = true;
            this.lblBakimBaslangicTarihSorgula.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakimBaslangicTarihSorgula.Location = new System.Drawing.Point(23, 34);
            this.lblBakimBaslangicTarihSorgula.Name = "lblBakimBaslangicTarihSorgula";
            this.lblBakimBaslangicTarihSorgula.Size = new System.Drawing.Size(128, 18);
            this.lblBakimBaslangicTarihSorgula.TabIndex = 58;
            this.lblBakimBaslangicTarihSorgula.Text = "Başlangıç Tarihi:";
            // 
            // dateTimeBaslangicSorgula
            // 
            this.dateTimeBaslangicSorgula.Location = new System.Drawing.Point(178, 31);
            this.dateTimeBaslangicSorgula.Name = "dateTimeBaslangicSorgula";
            this.dateTimeBaslangicSorgula.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBaslangicSorgula.TabIndex = 59;
            this.dateTimeBaslangicSorgula.ValueChanged += new System.EventHandler(this.dateTimeBaslangicSorgula_ValueChanged);
            // 
            // cmbBakimİsTuruSorgula
            // 
            this.cmbBakimİsTuruSorgula.FormattingEnabled = true;
            this.cmbBakimİsTuruSorgula.Location = new System.Drawing.Point(178, 83);
            this.cmbBakimİsTuruSorgula.Name = "cmbBakimİsTuruSorgula";
            this.cmbBakimİsTuruSorgula.Size = new System.Drawing.Size(200, 21);
            this.cmbBakimİsTuruSorgula.TabIndex = 60;
            // 
            // MaintenanceInquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1275, 647);
            this.Controls.Add(this.cmbBakimİsTuruSorgula);
            this.Controls.Add(this.dateTimeBaslangicSorgula);
            this.Controls.Add(this.lblBakimBaslangicTarihSorgula);
            this.Controls.Add(this.lblBakimİsTuruSorgula);
            this.Controls.Add(this.btn2SorgulaAnasayfayaDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn2SorgulaTemizle);
            this.Controls.Add(this.lbl2SorgulaSerino);
            this.Controls.Add(this.btn2SorgulaSorgula);
            this.Controls.Add(this.txtSorgulaSerino);
            this.Controls.Add(this.txtSorgulaEkipmanKod);
            this.Controls.Add(this.lbl2SorgulaEkipmanKodu);
            this.Name = "MaintenanceInquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceInquire";
            this.Load += new System.EventHandler(this.MaintenanceInquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2SorgulaAnasayfayaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn2SorgulaTemizle;
        private System.Windows.Forms.Label lbl2SorgulaSerino;
        private System.Windows.Forms.Button btn2SorgulaSorgula;
        private System.Windows.Forms.TextBox txtSorgulaSerino;
        private System.Windows.Forms.TextBox txtSorgulaEkipmanKod;
        private System.Windows.Forms.Label lbl2SorgulaEkipmanKodu;
        private System.Windows.Forms.Label lblBakimİsTuruSorgula;
        private System.Windows.Forms.Label lblBakimBaslangicTarihSorgula;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangicSorgula;
        private System.Windows.Forms.ComboBox cmbBakimİsTuruSorgula;
    }
}