namespace MovieRecommender
{
    partial class SignIn
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
            this.lblSignInSifre = new System.Windows.Forms.Label();
            this.lblSignInKullaniciAdi = new System.Windows.Forms.Label();
            this.txtbxSignInSifre = new System.Windows.Forms.TextBox();
            this.txtbxSignInKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtbxSignInSifreTekrar = new System.Windows.Forms.TextBox();
            this.lblSignInSifreTekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSignInSifre
            // 
            this.lblSignInSifre.AutoSize = true;
            this.lblSignInSifre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInSifre.Location = new System.Drawing.Point(326, 223);
            this.lblSignInSifre.Name = "lblSignInSifre";
            this.lblSignInSifre.Size = new System.Drawing.Size(35, 16);
            this.lblSignInSifre.TabIndex = 9;
            this.lblSignInSifre.Text = "Şifre";
            // 
            // lblSignInKullaniciAdi
            // 
            this.lblSignInKullaniciAdi.AutoSize = true;
            this.lblSignInKullaniciAdi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInKullaniciAdi.Location = new System.Drawing.Point(326, 130);
            this.lblSignInKullaniciAdi.Name = "lblSignInKullaniciAdi";
            this.lblSignInKullaniciAdi.Size = new System.Drawing.Size(77, 16);
            this.lblSignInKullaniciAdi.TabIndex = 8;
            this.lblSignInKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtbxSignInSifre
            // 
            this.txtbxSignInSifre.Location = new System.Drawing.Point(326, 254);
            this.txtbxSignInSifre.Multiline = true;
            this.txtbxSignInSifre.Name = "txtbxSignInSifre";
            this.txtbxSignInSifre.Size = new System.Drawing.Size(207, 23);
            this.txtbxSignInSifre.TabIndex = 7;
            // 
            // txtbxSignInKullaniciAdi
            // 
            this.txtbxSignInKullaniciAdi.Location = new System.Drawing.Point(326, 163);
            this.txtbxSignInKullaniciAdi.Multiline = true;
            this.txtbxSignInKullaniciAdi.Name = "txtbxSignInKullaniciAdi";
            this.txtbxSignInKullaniciAdi.Size = new System.Drawing.Size(207, 23);
            this.txtbxSignInKullaniciAdi.TabIndex = 6;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(389, 412);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(87, 27);
            this.btnAdminGiris.TabIndex = 5;
            this.btnAdminGiris.Text = "Kayıt Ol";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txtbxSignInSifreTekrar
            // 
            this.txtbxSignInSifreTekrar.Location = new System.Drawing.Point(326, 336);
            this.txtbxSignInSifreTekrar.Multiline = true;
            this.txtbxSignInSifreTekrar.Name = "txtbxSignInSifreTekrar";
            this.txtbxSignInSifreTekrar.Size = new System.Drawing.Size(207, 23);
            this.txtbxSignInSifreTekrar.TabIndex = 10;
            // 
            // lblSignInSifreTekrar
            // 
            this.lblSignInSifreTekrar.AutoSize = true;
            this.lblSignInSifreTekrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInSifreTekrar.Location = new System.Drawing.Point(326, 301);
            this.lblSignInSifreTekrar.Name = "lblSignInSifreTekrar";
            this.lblSignInSifreTekrar.Size = new System.Drawing.Size(76, 16);
            this.lblSignInSifreTekrar.TabIndex = 11;
            this.lblSignInSifreTekrar.Text = "Şifre Tekrar";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblSignInSifreTekrar);
            this.Controls.Add(this.txtbxSignInSifreTekrar);
            this.Controls.Add(this.lblSignInSifre);
            this.Controls.Add(this.lblSignInKullaniciAdi);
            this.Controls.Add(this.txtbxSignInSifre);
            this.Controls.Add(this.txtbxSignInKullaniciAdi);
            this.Controls.Add(this.btnAdminGiris);
            this.Name = "SignIn";
            this.Text = "Movie Recommender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignInSifre;
        private System.Windows.Forms.Label lblSignInKullaniciAdi;
        private System.Windows.Forms.TextBox txtbxSignInSifre;
        private System.Windows.Forms.TextBox txtbxSignInKullaniciAdi;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtbxSignInSifreTekrar;
        private System.Windows.Forms.Label lblSignInSifreTekrar;
    }
}