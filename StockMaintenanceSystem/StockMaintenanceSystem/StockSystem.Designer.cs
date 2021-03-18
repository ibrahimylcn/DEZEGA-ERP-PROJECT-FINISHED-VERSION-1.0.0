
namespace StockMaintenanceSystem
{
    partial class StockSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSystem));
            this.txtYeniKod = new System.Windows.Forms.TextBox();
            this.lblYeniKategori = new System.Windows.Forms.Label();
            this.btnYeniKaydet = new System.Windows.Forms.Button();
            this.btnYeniAnasayfa = new System.Windows.Forms.Button();
            this.BtnYeniTemizle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnYeniGelen = new System.Windows.Forms.Button();
            this.btnYeniCikan = new System.Windows.Forms.Button();
            this.lblYeniAmacNeden = new System.Windows.Forms.Label();
            this.lblYeniSiparisKodu = new System.Windows.Forms.Label();
            this.lblYeniFirma = new System.Windows.Forms.Label();
            this.lblYeniAdet = new System.Windows.Forms.Label();
            this.lblYeniSerino = new System.Windows.Forms.Label();
            this.lblYeniModel = new System.Windows.Forms.Label();
            this.lblYeniMarka = new System.Windows.Forms.Label();
            this.lblYeniKod = new System.Windows.Forms.Label();
            this.lnlYeniTarih = new System.Windows.Forms.Label();
            this.lblYeniAlan = new System.Windows.Forms.Label();
            this.lblYeniAdi = new System.Windows.Forms.Label();
            this.cmbYeniKategori = new System.Windows.Forms.ComboBox();
            this.dTimeYeniTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYeniAdet = new System.Windows.Forms.TextBox();
            this.txtYeniModel = new System.Windows.Forms.TextBox();
            this.txtYeniMarkasi = new System.Windows.Forms.TextBox();
            this.txtYeniAdi = new System.Windows.Forms.TextBox();
            this.txtYeniAlan = new System.Windows.Forms.TextBox();
            this.txtYeniSiparisKodu = new System.Windows.Forms.TextBox();
            this.txtYeniFirma = new System.Windows.Forms.TextBox();
            this.txtYeniSerino = new System.Windows.Forms.TextBox();
            this.dataGridViewYeni = new System.Windows.Forms.DataGridView();
            this.btnYeniSorgula = new System.Windows.Forms.Button();
            this.txtYeniAmacNeden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYeni)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYeniKod
            // 
            this.txtYeniKod.Location = new System.Drawing.Point(193, 62);
            this.txtYeniKod.Name = "txtYeniKod";
            this.txtYeniKod.Size = new System.Drawing.Size(121, 20);
            this.txtYeniKod.TabIndex = 0;
            // 
            // lblYeniKategori
            // 
            this.lblYeniKategori.AutoSize = true;
            this.lblYeniKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniKategori.Location = new System.Drawing.Point(38, 24);
            this.lblYeniKategori.Name = "lblYeniKategori";
            this.lblYeniKategori.Size = new System.Drawing.Size(65, 15);
            this.lblYeniKategori.TabIndex = 1;
            this.lblYeniKategori.Text = "Kategori:";
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.BackColor = System.Drawing.Color.White;
            this.btnYeniKaydet.Location = new System.Drawing.Point(872, 351);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(111, 41);
            this.btnYeniKaydet.TabIndex = 2;
            this.btnYeniKaydet.Text = "Kaydet";
            this.btnYeniKaydet.UseVisualStyleBackColor = false;
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // btnYeniAnasayfa
            // 
            this.btnYeniAnasayfa.BackColor = System.Drawing.Color.Lime;
            this.btnYeniAnasayfa.Location = new System.Drawing.Point(872, 445);
            this.btnYeniAnasayfa.Name = "btnYeniAnasayfa";
            this.btnYeniAnasayfa.Size = new System.Drawing.Size(111, 41);
            this.btnYeniAnasayfa.TabIndex = 3;
            this.btnYeniAnasayfa.Text = "Anasayfa";
            this.btnYeniAnasayfa.UseVisualStyleBackColor = false;
            this.btnYeniAnasayfa.Click += new System.EventHandler(this.btnYeniAnasayfa_Click);
            // 
            // BtnYeniTemizle
            // 
            this.BtnYeniTemizle.BackColor = System.Drawing.Color.White;
            this.BtnYeniTemizle.Location = new System.Drawing.Point(872, 398);
            this.BtnYeniTemizle.Name = "BtnYeniTemizle";
            this.BtnYeniTemizle.Size = new System.Drawing.Size(111, 41);
            this.BtnYeniTemizle.TabIndex = 4;
            this.BtnYeniTemizle.Text = "Temizle";
            this.BtnYeniTemizle.UseVisualStyleBackColor = false;
            this.BtnYeniTemizle.Click += new System.EventHandler(this.BtnYeniTemizle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(872, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(111, 45);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnYeniGelen
            // 
            this.btnYeniGelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniGelen.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniGelen.Image")));
            this.btnYeniGelen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniGelen.Location = new System.Drawing.Point(872, 56);
            this.btnYeniGelen.Name = "btnYeniGelen";
            this.btnYeniGelen.Size = new System.Drawing.Size(111, 45);
            this.btnYeniGelen.TabIndex = 6;
            this.btnYeniGelen.Text = "GELEN";
            this.btnYeniGelen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniGelen.UseVisualStyleBackColor = true;
            this.btnYeniGelen.Click += new System.EventHandler(this.btnYeniGelen_Click);
            // 
            // btnYeniCikan
            // 
            this.btnYeniCikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniCikan.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniCikan.Image")));
            this.btnYeniCikan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniCikan.Location = new System.Drawing.Point(872, 107);
            this.btnYeniCikan.Name = "btnYeniCikan";
            this.btnYeniCikan.Size = new System.Drawing.Size(111, 45);
            this.btnYeniCikan.TabIndex = 7;
            this.btnYeniCikan.Text = "ÇIKAN";
            this.btnYeniCikan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniCikan.UseVisualStyleBackColor = true;
            this.btnYeniCikan.Click += new System.EventHandler(this.btnYeniCikan_Click);
            // 
            // lblYeniAmacNeden
            // 
            this.lblYeniAmacNeden.AutoSize = true;
            this.lblYeniAmacNeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniAmacNeden.Location = new System.Drawing.Point(438, 226);
            this.lblYeniAmacNeden.Name = "lblYeniAmacNeden";
            this.lblYeniAmacNeden.Size = new System.Drawing.Size(93, 15);
            this.lblYeniAmacNeden.TabIndex = 8;
            this.lblYeniAmacNeden.Text = "Amaç-Neden:";
            // 
            // lblYeniSiparisKodu
            // 
            this.lblYeniSiparisKodu.AutoSize = true;
            this.lblYeniSiparisKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniSiparisKodu.Location = new System.Drawing.Point(438, 183);
            this.lblYeniSiparisKodu.Name = "lblYeniSiparisKodu";
            this.lblYeniSiparisKodu.Size = new System.Drawing.Size(93, 15);
            this.lblYeniSiparisKodu.TabIndex = 9;
            this.lblYeniSiparisKodu.Text = "Sipariş Kodu:";
            // 
            // lblYeniFirma
            // 
            this.lblYeniFirma.AutoSize = true;
            this.lblYeniFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniFirma.Location = new System.Drawing.Point(438, 141);
            this.lblYeniFirma.Name = "lblYeniFirma";
            this.lblYeniFirma.Size = new System.Drawing.Size(48, 15);
            this.lblYeniFirma.TabIndex = 10;
            this.lblYeniFirma.Text = "Firma:";
            // 
            // lblYeniAdet
            // 
            this.lblYeniAdet.AutoSize = true;
            this.lblYeniAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniAdet.Location = new System.Drawing.Point(438, 98);
            this.lblYeniAdet.Name = "lblYeniAdet";
            this.lblYeniAdet.Size = new System.Drawing.Size(39, 15);
            this.lblYeniAdet.TabIndex = 11;
            this.lblYeniAdet.Text = "Adet:";
            // 
            // lblYeniSerino
            // 
            this.lblYeniSerino.AutoSize = true;
            this.lblYeniSerino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniSerino.Location = new System.Drawing.Point(438, 63);
            this.lblYeniSerino.Name = "lblYeniSerino";
            this.lblYeniSerino.Size = new System.Drawing.Size(103, 15);
            this.lblYeniSerino.TabIndex = 12;
            this.lblYeniSerino.Text = "Seri Numarası:";
            // 
            // lblYeniModel
            // 
            this.lblYeniModel.AutoSize = true;
            this.lblYeniModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniModel.Location = new System.Drawing.Point(38, 183);
            this.lblYeniModel.Name = "lblYeniModel";
            this.lblYeniModel.Size = new System.Drawing.Size(111, 15);
            this.lblYeniModel.TabIndex = 13;
            this.lblYeniModel.Text = "Ekipman Model:";
            // 
            // lblYeniMarka
            // 
            this.lblYeniMarka.AutoSize = true;
            this.lblYeniMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniMarka.Location = new System.Drawing.Point(38, 144);
            this.lblYeniMarka.Name = "lblYeniMarka";
            this.lblYeniMarka.Size = new System.Drawing.Size(111, 15);
            this.lblYeniMarka.TabIndex = 14;
            this.lblYeniMarka.Text = "Ekipman Marka:";
            // 
            // lblYeniKod
            // 
            this.lblYeniKod.AutoSize = true;
            this.lblYeniKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniKod.Location = new System.Drawing.Point(38, 63);
            this.lblYeniKod.Name = "lblYeniKod";
            this.lblYeniKod.Size = new System.Drawing.Size(104, 15);
            this.lblYeniKod.TabIndex = 15;
            this.lblYeniKod.Text = "Ekipman Kodu:";
            // 
            // lnlYeniTarih
            // 
            this.lnlYeniTarih.AutoSize = true;
            this.lnlYeniTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lnlYeniTarih.Location = new System.Drawing.Point(438, 32);
            this.lnlYeniTarih.Name = "lnlYeniTarih";
            this.lnlYeniTarih.Size = new System.Drawing.Size(44, 15);
            this.lnlYeniTarih.TabIndex = 17;
            this.lnlYeniTarih.Text = "Tarih:";
            // 
            // lblYeniAlan
            // 
            this.lblYeniAlan.AutoSize = true;
            this.lblYeniAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniAlan.Location = new System.Drawing.Point(38, 226);
            this.lblYeniAlan.Name = "lblYeniAlan";
            this.lblYeniAlan.Size = new System.Drawing.Size(112, 15);
            this.lblYeniAlan.TabIndex = 18;
            this.lblYeniAlan.Text = "Bulunduğu Alan:";
            // 
            // lblYeniAdi
            // 
            this.lblYeniAdi.AutoSize = true;
            this.lblYeniAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblYeniAdi.Location = new System.Drawing.Point(38, 105);
            this.lblYeniAdi.Name = "lblYeniAdi";
            this.lblYeniAdi.Size = new System.Drawing.Size(91, 15);
            this.lblYeniAdi.TabIndex = 19;
            this.lblYeniAdi.Text = "Ekipman Adı:";
            // 
            // cmbYeniKategori
            // 
            this.cmbYeniKategori.FormattingEnabled = true;
            this.cmbYeniKategori.Location = new System.Drawing.Point(193, 24);
            this.cmbYeniKategori.Name = "cmbYeniKategori";
            this.cmbYeniKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbYeniKategori.TabIndex = 20;
            // 
            // dTimeYeniTarih
            // 
            this.dTimeYeniTarih.Location = new System.Drawing.Point(559, 32);
            this.dTimeYeniTarih.Name = "dTimeYeniTarih";
            this.dTimeYeniTarih.Size = new System.Drawing.Size(200, 20);
            this.dTimeYeniTarih.TabIndex = 21;
            // 
            // txtYeniAdet
            // 
            this.txtYeniAdet.Location = new System.Drawing.Point(559, 100);
            this.txtYeniAdet.Name = "txtYeniAdet";
            this.txtYeniAdet.Size = new System.Drawing.Size(121, 20);
            this.txtYeniAdet.TabIndex = 22;
            // 
            // txtYeniModel
            // 
            this.txtYeniModel.Location = new System.Drawing.Point(193, 183);
            this.txtYeniModel.Name = "txtYeniModel";
            this.txtYeniModel.Size = new System.Drawing.Size(121, 20);
            this.txtYeniModel.TabIndex = 23;
            // 
            // txtYeniMarkasi
            // 
            this.txtYeniMarkasi.Location = new System.Drawing.Point(193, 144);
            this.txtYeniMarkasi.Name = "txtYeniMarkasi";
            this.txtYeniMarkasi.Size = new System.Drawing.Size(121, 20);
            this.txtYeniMarkasi.TabIndex = 24;
            // 
            // txtYeniAdi
            // 
            this.txtYeniAdi.Location = new System.Drawing.Point(193, 105);
            this.txtYeniAdi.Name = "txtYeniAdi";
            this.txtYeniAdi.Size = new System.Drawing.Size(121, 20);
            this.txtYeniAdi.TabIndex = 25;
            // 
            // txtYeniAlan
            // 
            this.txtYeniAlan.Location = new System.Drawing.Point(193, 226);
            this.txtYeniAlan.Name = "txtYeniAlan";
            this.txtYeniAlan.Size = new System.Drawing.Size(121, 20);
            this.txtYeniAlan.TabIndex = 26;
            // 
            // txtYeniSiparisKodu
            // 
            this.txtYeniSiparisKodu.Location = new System.Drawing.Point(559, 183);
            this.txtYeniSiparisKodu.Name = "txtYeniSiparisKodu";
            this.txtYeniSiparisKodu.Size = new System.Drawing.Size(121, 20);
            this.txtYeniSiparisKodu.TabIndex = 27;
            // 
            // txtYeniFirma
            // 
            this.txtYeniFirma.Location = new System.Drawing.Point(559, 141);
            this.txtYeniFirma.Name = "txtYeniFirma";
            this.txtYeniFirma.Size = new System.Drawing.Size(121, 20);
            this.txtYeniFirma.TabIndex = 28;
            // 
            // txtYeniSerino
            // 
            this.txtYeniSerino.Location = new System.Drawing.Point(559, 63);
            this.txtYeniSerino.Name = "txtYeniSerino";
            this.txtYeniSerino.Size = new System.Drawing.Size(121, 20);
            this.txtYeniSerino.TabIndex = 29;
            // 
            // dataGridViewYeni
            // 
            this.dataGridViewYeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYeni.Location = new System.Drawing.Point(38, 299);
            this.dataGridViewYeni.Name = "dataGridViewYeni";
            this.dataGridViewYeni.Size = new System.Drawing.Size(807, 208);
            this.dataGridViewYeni.TabIndex = 30;
            // 
            // btnYeniSorgula
            // 
            this.btnYeniSorgula.BackColor = System.Drawing.Color.White;
            this.btnYeniSorgula.Location = new System.Drawing.Point(872, 162);
            this.btnYeniSorgula.Name = "btnYeniSorgula";
            this.btnYeniSorgula.Size = new System.Drawing.Size(111, 41);
            this.btnYeniSorgula.TabIndex = 31;
            this.btnYeniSorgula.Text = "Sorgula";
            this.btnYeniSorgula.UseVisualStyleBackColor = false;
            this.btnYeniSorgula.Click += new System.EventHandler(this.btnYeniSorgula_Click);
            // 
            // txtYeniAmacNeden
            // 
            this.txtYeniAmacNeden.Location = new System.Drawing.Point(559, 226);
            this.txtYeniAmacNeden.Multiline = true;
            this.txtYeniAmacNeden.Name = "txtYeniAmacNeden";
            this.txtYeniAmacNeden.Size = new System.Drawing.Size(211, 67);
            this.txtYeniAmacNeden.TabIndex = 32;
            this.txtYeniAmacNeden.TextChanged += new System.EventHandler(this.txtYeni_TextChanged);
            // 
            // StockSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1017, 511);
            this.Controls.Add(this.txtYeniAmacNeden);
            this.Controls.Add(this.btnYeniSorgula);
            this.Controls.Add(this.dataGridViewYeni);
            this.Controls.Add(this.txtYeniSerino);
            this.Controls.Add(this.txtYeniFirma);
            this.Controls.Add(this.txtYeniSiparisKodu);
            this.Controls.Add(this.txtYeniAlan);
            this.Controls.Add(this.txtYeniAdi);
            this.Controls.Add(this.txtYeniMarkasi);
            this.Controls.Add(this.txtYeniModel);
            this.Controls.Add(this.txtYeniAdet);
            this.Controls.Add(this.dTimeYeniTarih);
            this.Controls.Add(this.cmbYeniKategori);
            this.Controls.Add(this.lblYeniAdi);
            this.Controls.Add(this.lblYeniAlan);
            this.Controls.Add(this.lnlYeniTarih);
            this.Controls.Add(this.lblYeniKod);
            this.Controls.Add(this.lblYeniMarka);
            this.Controls.Add(this.lblYeniModel);
            this.Controls.Add(this.lblYeniSerino);
            this.Controls.Add(this.lblYeniAdet);
            this.Controls.Add(this.lblYeniFirma);
            this.Controls.Add(this.lblYeniSiparisKodu);
            this.Controls.Add(this.lblYeniAmacNeden);
            this.Controls.Add(this.btnYeniCikan);
            this.Controls.Add(this.btnYeniGelen);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.BtnYeniTemizle);
            this.Controls.Add(this.btnYeniAnasayfa);
            this.Controls.Add(this.btnYeniKaydet);
            this.Controls.Add(this.lblYeniKategori);
            this.Controls.Add(this.txtYeniKod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "StockSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniKod;
        private System.Windows.Forms.Label lblYeniKategori;
        private System.Windows.Forms.Button btnYeniKaydet;
        private System.Windows.Forms.Button btnYeniAnasayfa;
        private System.Windows.Forms.Button BtnYeniTemizle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnYeniGelen;
        private System.Windows.Forms.Button btnYeniCikan;
        private System.Windows.Forms.Label lblYeniAmacNeden;
        private System.Windows.Forms.Label lblYeniSiparisKodu;
        private System.Windows.Forms.Label lblYeniFirma;
        private System.Windows.Forms.Label lblYeniAdet;
        private System.Windows.Forms.Label lblYeniSerino;
        private System.Windows.Forms.Label lblYeniModel;
        private System.Windows.Forms.Label lblYeniMarka;
        private System.Windows.Forms.Label lblYeniKod;
        private System.Windows.Forms.Label lnlYeniTarih;
        private System.Windows.Forms.Label lblYeniAlan;
        private System.Windows.Forms.Label lblYeniAdi;
        private System.Windows.Forms.ComboBox cmbYeniKategori;
        private System.Windows.Forms.DateTimePicker dTimeYeniTarih;
        private System.Windows.Forms.TextBox txtYeniAdet;
        private System.Windows.Forms.TextBox txtYeniModel;
        private System.Windows.Forms.TextBox txtYeniMarkasi;
        private System.Windows.Forms.TextBox txtYeniAdi;
        private System.Windows.Forms.TextBox txtYeniAlan;
        private System.Windows.Forms.TextBox txtYeniSiparisKodu;
        private System.Windows.Forms.TextBox txtYeniFirma;
        private System.Windows.Forms.TextBox txtYeniSerino;
        private System.Windows.Forms.DataGridView dataGridViewYeni;
        private System.Windows.Forms.Button btnYeniSorgula;
        private System.Windows.Forms.TextBox txtYeniAmacNeden;
    }
}