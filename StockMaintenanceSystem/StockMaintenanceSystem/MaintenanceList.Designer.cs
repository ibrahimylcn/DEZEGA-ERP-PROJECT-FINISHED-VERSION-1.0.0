
namespace StockMaintenanceSystem
{
    partial class MaintenanceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLBakimAnasayfaDon = new System.Windows.Forms.Button();
            this.dataGridViewBakimListele = new System.Windows.Forms.DataGridView();
            this.pictureBoxBakim = new System.Windows.Forms.PictureBox();
            this.btnBakımListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakimListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBakim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(990, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnLBakimAnasayfaDon
            // 
            this.btnLBakimAnasayfaDon.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLBakimAnasayfaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLBakimAnasayfaDon.Image")));
            this.btnLBakimAnasayfaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLBakimAnasayfaDon.Location = new System.Drawing.Point(1187, 94);
            this.btnLBakimAnasayfaDon.Name = "btnLBakimAnasayfaDon";
            this.btnLBakimAnasayfaDon.Size = new System.Drawing.Size(78, 41);
            this.btnLBakimAnasayfaDon.TabIndex = 49;
            this.btnLBakimAnasayfaDon.Text = "GERİ";
            this.btnLBakimAnasayfaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLBakimAnasayfaDon.UseVisualStyleBackColor = true;
            this.btnLBakimAnasayfaDon.Click += new System.EventHandler(this.btnLBakimAnasayfaDon_Click);
            // 
            // dataGridViewBakimListele
            // 
            this.dataGridViewBakimListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBakimListele.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewBakimListele.Name = "dataGridViewBakimListele";
            this.dataGridViewBakimListele.Size = new System.Drawing.Size(1253, 497);
            this.dataGridViewBakimListele.TabIndex = 50;
            // 
            // pictureBoxBakim
            // 
            this.pictureBoxBakim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBakim.Image")));
            this.pictureBoxBakim.Location = new System.Drawing.Point(373, 29);
            this.pictureBoxBakim.Name = "pictureBoxBakim";
            this.pictureBoxBakim.Size = new System.Drawing.Size(67, 69);
            this.pictureBoxBakim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBakim.TabIndex = 52;
            this.pictureBoxBakim.TabStop = false;
            // 
            // btnBakımListele
            // 
            this.btnBakımListele.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakımListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBakımListele.Location = new System.Drawing.Point(473, 42);
            this.btnBakımListele.Name = "btnBakımListele";
            this.btnBakımListele.Size = new System.Drawing.Size(247, 46);
            this.btnBakımListele.TabIndex = 51;
            this.btnBakımListele.Text = "Tümünü Listele";
            this.btnBakımListele.UseVisualStyleBackColor = true;
            this.btnBakımListele.Click += new System.EventHandler(this.btnBakımListele_Click);
            // 
            // MaintenanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1269, 644);
            this.Controls.Add(this.pictureBoxBakim);
            this.Controls.Add(this.btnBakımListele);
            this.Controls.Add(this.dataGridViewBakimListele);
            this.Controls.Add(this.btnLBakimAnasayfaDon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakimListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBakim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLBakimAnasayfaDon;
        private System.Windows.Forms.DataGridView dataGridViewBakimListele;
        private System.Windows.Forms.PictureBox pictureBoxBakim;
        private System.Windows.Forms.Button btnBakımListele;
    }
}