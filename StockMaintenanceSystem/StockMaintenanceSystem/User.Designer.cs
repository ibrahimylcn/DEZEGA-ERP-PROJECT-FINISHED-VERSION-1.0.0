
namespace StockMaintenanceSystem
{
    partial class User
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpswd = new System.Windows.Forms.Label();
            this.txtpswd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(56, 128);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(32, 13);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "User:";
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtuser.Location = new System.Drawing.Point(160, 125);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(123, 20);
            this.txtuser.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(160, 244);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(123, 31);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpswd
            // 
            this.lblpswd.AutoSize = true;
            this.lblpswd.Location = new System.Drawing.Point(56, 201);
            this.lblpswd.Name = "lblpswd";
            this.lblpswd.Size = new System.Drawing.Size(56, 13);
            this.lblpswd.TabIndex = 3;
            this.lblpswd.Text = "Password:";
            this.lblpswd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpswd
            // 
            this.txtpswd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpswd.Location = new System.Drawing.Point(160, 198);
            this.txtpswd.Name = "txtpswd";
            this.txtpswd.PasswordChar = '*';
            this.txtpswd.Size = new System.Drawing.Size(123, 20);
            this.txtpswd.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(379, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpswd);
            this.Controls.Add(this.lblpswd);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpswd;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

