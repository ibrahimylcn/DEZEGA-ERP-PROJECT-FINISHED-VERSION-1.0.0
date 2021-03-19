
namespace StockMaintenanceSystem
{
    partial class Inquire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inquire));
            this.lblSorgulaEkipmanKodu = new System.Windows.Forms.Label();
            this.txtSorgulaEkipmanKod = new System.Windows.Forms.TextBox();
            this.txtSorgulaSerino = new System.Windows.Forms.TextBox();
            this.btnSorgulaSorgula = new System.Windows.Forms.Button();
            this.lblSorgulaSerino = new System.Windows.Forms.Label();
            this.btnSorgulaTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSorgulaAnasayfayadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSorgulaEkipmanKodu
            // 
            this.lblSorgulaEkipmanKodu.AutoSize = true;
            this.lblSorgulaEkipmanKodu.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorgulaEkipmanKodu.Location = new System.Drawing.Point(143, 26);
            this.lblSorgulaEkipmanKodu.Name = "lblSorgulaEkipmanKodu";
            this.lblSorgulaEkipmanKodu.Size = new System.Drawing.Size(114, 18);
            this.lblSorgulaEkipmanKodu.TabIndex = 0;
            this.lblSorgulaEkipmanKodu.Text = "Ekipman Kodu:";
            // 
            // txtSorgulaEkipmanKod
            // 
            this.txtSorgulaEkipmanKod.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorgulaEkipmanKod.Location = new System.Drawing.Point(286, 24);
            this.txtSorgulaEkipmanKod.Name = "txtSorgulaEkipmanKod";
            this.txtSorgulaEkipmanKod.Size = new System.Drawing.Size(256, 22);
            this.txtSorgulaEkipmanKod.TabIndex = 1;
            this.txtSorgulaEkipmanKod.TextChanged += new System.EventHandler(this.txtSorgulaEkipmanKod_TextChanged);
            // 
            // txtSorgulaSerino
            // 
            this.txtSorgulaSerino.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorgulaSerino.Location = new System.Drawing.Point(286, 79);
            this.txtSorgulaSerino.Name = "txtSorgulaSerino";
            this.txtSorgulaSerino.Size = new System.Drawing.Size(256, 22);
            this.txtSorgulaSerino.TabIndex = 2;
            // 
            // btnSorgulaSorgula
            // 
            this.btnSorgulaSorgula.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorgulaSorgula.Image = ((System.Drawing.Image)(resources.GetObject("btnSorgulaSorgula.Image")));
            this.btnSorgulaSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSorgulaSorgula.Location = new System.Drawing.Point(655, 12);
            this.btnSorgulaSorgula.Name = "btnSorgulaSorgula";
            this.btnSorgulaSorgula.Size = new System.Drawing.Size(115, 49);
            this.btnSorgulaSorgula.TabIndex = 3;
            this.btnSorgulaSorgula.Text = "Sorgula";
            this.btnSorgulaSorgula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSorgulaSorgula.UseVisualStyleBackColor = true;
            this.btnSorgulaSorgula.Click += new System.EventHandler(this.btnSorgulaSorgula_Click);
            // 
            // lblSorgulaSerino
            // 
            this.lblSorgulaSerino.AutoSize = true;
            this.lblSorgulaSerino.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorgulaSerino.Location = new System.Drawing.Point(146, 81);
            this.lblSorgulaSerino.Name = "lblSorgulaSerino";
            this.lblSorgulaSerino.Size = new System.Drawing.Size(112, 18);
            this.lblSorgulaSerino.TabIndex = 4;
            this.lblSorgulaSerino.Text = "Seri Numarası:";
            // 
            // btnSorgulaTemizle
            // 
            this.btnSorgulaTemizle.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorgulaTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnSorgulaTemizle.Image")));
            this.btnSorgulaTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSorgulaTemizle.Location = new System.Drawing.Point(655, 67);
            this.btnSorgulaTemizle.Name = "btnSorgulaTemizle";
            this.btnSorgulaTemizle.Size = new System.Drawing.Size(115, 48);
            this.btnSorgulaTemizle.TabIndex = 5;
            this.btnSorgulaTemizle.Text = "Temizle";
            this.btnSorgulaTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSorgulaTemizle.UseVisualStyleBackColor = true;
            this.btnSorgulaTemizle.Click += new System.EventHandler(this.btnSorgulaTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 484);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(981, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnSorgulaAnasayfayadon
            // 
            this.btnSorgulaAnasayfayadon.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorgulaAnasayfayadon.Image = ((System.Drawing.Image)(resources.GetObject("btnSorgulaAnasayfayadon.Image")));
            this.btnSorgulaAnasayfayadon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSorgulaAnasayfayadon.Location = new System.Drawing.Point(1178, 99);
            this.btnSorgulaAnasayfayadon.Name = "btnSorgulaAnasayfayadon";
            this.btnSorgulaAnasayfayadon.Size = new System.Drawing.Size(78, 41);
            this.btnSorgulaAnasayfayadon.TabIndex = 47;
            this.btnSorgulaAnasayfayadon.Text = "GERİ";
            this.btnSorgulaAnasayfayadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSorgulaAnasayfayadon.UseVisualStyleBackColor = true;
            this.btnSorgulaAnasayfayadon.Click += new System.EventHandler(this.btnSorgulaAnasayfayadon_Click);
            // 
            // Inquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1276, 648);
            this.Controls.Add(this.btnSorgulaAnasayfayadon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSorgulaTemizle);
            this.Controls.Add(this.lblSorgulaSerino);
            this.Controls.Add(this.btnSorgulaSorgula);
            this.Controls.Add(this.txtSorgulaSerino);
            this.Controls.Add(this.txtSorgulaEkipmanKod);
            this.Controls.Add(this.lblSorgulaEkipmanKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Inquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " STOK TAKİP SORGULAMA";
            this.Load += new System.EventHandler(this.Inquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorgulaEkipmanKodu;
        private System.Windows.Forms.TextBox txtSorgulaEkipmanKod;
        private System.Windows.Forms.TextBox txtSorgulaSerino;
        private System.Windows.Forms.Button btnSorgulaSorgula;
        private System.Windows.Forms.Label lblSorgulaSerino;
        private System.Windows.Forms.Button btnSorgulaTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSorgulaAnasayfayadon;
    }
}