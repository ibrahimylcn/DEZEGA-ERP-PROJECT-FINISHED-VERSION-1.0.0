
namespace StockMaintenanceSystem
{
    partial class StockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListeleAnasayfaDon = new System.Windows.Forms.Button();
            this.dataGridViewTumunuListele = new System.Windows.Forms.DataGridView();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.lblListele = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumunuListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(992, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnListeleAnasayfaDon
            // 
            this.btnListeleAnasayfaDon.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeleAnasayfaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnListeleAnasayfaDon.Image")));
            this.btnListeleAnasayfaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListeleAnasayfaDon.Location = new System.Drawing.Point(1189, 94);
            this.btnListeleAnasayfaDon.Name = "btnListeleAnasayfaDon";
            this.btnListeleAnasayfaDon.Size = new System.Drawing.Size(78, 41);
            this.btnListeleAnasayfaDon.TabIndex = 48;
            this.btnListeleAnasayfaDon.Text = "GERİ";
            this.btnListeleAnasayfaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeleAnasayfaDon.UseVisualStyleBackColor = true;
            this.btnListeleAnasayfaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTumunuListele
            // 
            this.dataGridViewTumunuListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumunuListele.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewTumunuListele.Name = "dataGridViewTumunuListele";
            this.dataGridViewTumunuListele.Size = new System.Drawing.Size(1255, 502);
            this.dataGridViewTumunuListele.TabIndex = 49;
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxList.Image")));
            this.pictureBoxList.Location = new System.Drawing.Point(405, 29);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(67, 69);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList.TabIndex = 50;
            this.pictureBoxList.TabStop = false;
            this.pictureBoxList.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblListele
            // 
            this.lblListele.AutoSize = true;
            this.lblListele.Font = new System.Drawing.Font("Leelawadee", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListele.Location = new System.Drawing.Point(12, 121);
            this.lblListele.Name = "lblListele";
            this.lblListele.Size = new System.Drawing.Size(159, 14);
            this.lblListele.TabIndex = 51;
            this.lblListele.Text = "Tüm Stoklarınızı Listeleyin\r\n";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Leelawadee", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.Location = new System.Drawing.Point(505, 42);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(247, 46);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1279, 648);
            this.Controls.Add(this.lblListele);
            this.Controls.Add(this.pictureBoxList);
            this.Controls.Add(this.dataGridViewTumunuListele);
            this.Controls.Add(this.btnListeleAnasayfaDon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumunuListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListeleAnasayfaDon;
        private System.Windows.Forms.DataGridView dataGridViewTumunuListele;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.Label lblListele;
        private System.Windows.Forms.Button btnListele;
    }
}