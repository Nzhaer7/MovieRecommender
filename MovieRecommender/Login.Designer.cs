namespace MovieRecommender
{
    partial class Login
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtbxLoginKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtbxLoginSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdiminSifremiUnuttum = new System.Windows.Forms.Label();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.btnLoginGeriGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(370, 378);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(87, 27);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txtbxLoginKullaniciAdi
            // 
            this.txtbxLoginKullaniciAdi.Location = new System.Drawing.Point(305, 148);
            this.txtbxLoginKullaniciAdi.Multiline = true;
            this.txtbxLoginKullaniciAdi.Name = "txtbxLoginKullaniciAdi";
            this.txtbxLoginKullaniciAdi.Size = new System.Drawing.Size(207, 23);
            this.txtbxLoginKullaniciAdi.TabIndex = 1;
            // 
            // txtbxLoginSifre
            // 
            this.txtbxLoginSifre.Location = new System.Drawing.Point(305, 274);
            this.txtbxLoginSifre.Multiline = true;
            this.txtbxLoginSifre.Name = "txtbxLoginSifre";
            this.txtbxLoginSifre.Size = new System.Drawing.Size(207, 23);
            this.txtbxLoginSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // lblAdiminSifremiUnuttum
            // 
            this.lblAdiminSifremiUnuttum.AutoSize = true;
            this.lblAdiminSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdiminSifremiUnuttum.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdiminSifremiUnuttum.Location = new System.Drawing.Point(362, 435);
            this.lblAdiminSifremiUnuttum.Name = "lblAdiminSifremiUnuttum";
            this.lblAdiminSifremiUnuttum.Size = new System.Drawing.Size(102, 16);
            this.lblAdiminSifremiUnuttum.TabIndex = 5;
            this.lblAdiminSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblAdiminSifremiUnuttum.Click += new System.EventHandler(this.lblAdiminSifremiUnuttum_Click);
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKayitOl.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblKayitOl.Location = new System.Drawing.Point(380, 469);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(61, 19);
            this.lblKayitOl.TabIndex = 6;
            this.lblKayitOl.Text = "Kayıt Ol";
            this.lblKayitOl.Click += new System.EventHandler(this.lblKayitOl_Click);
            // 
            // btnLoginGeriGit
            // 
            this.btnLoginGeriGit.Location = new System.Drawing.Point(12, 12);
            this.btnLoginGeriGit.Name = "btnLoginGeriGit";
            this.btnLoginGeriGit.Size = new System.Drawing.Size(75, 23);
            this.btnLoginGeriGit.TabIndex = 19;
            this.btnLoginGeriGit.Text = "Geri Git";
            this.btnLoginGeriGit.UseVisualStyleBackColor = true;
            this.btnLoginGeriGit.Click += new System.EventHandler(this.btnLoginGeriGit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnLoginGeriGit);
            this.Controls.Add(this.lblKayitOl);
            this.Controls.Add(this.lblAdiminSifremiUnuttum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxLoginSifre);
            this.Controls.Add(this.txtbxLoginKullaniciAdi);
            this.Controls.Add(this.btnAdminGiris);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Recommender";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtbxLoginKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxLoginSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdiminSifremiUnuttum;
        private System.Windows.Forms.Label lblKayitOl;
        private System.Windows.Forms.Button btnLoginGeriGit;
    }
}