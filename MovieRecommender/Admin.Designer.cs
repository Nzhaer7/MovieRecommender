namespace MovieRecommender
{
    partial class Admin
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
            this.grpbxAdmin = new System.Windows.Forms.GroupBox();
            this.btnAdminGuncelle = new System.Windows.Forms.Button();
            this.btnAdminSil = new System.Windows.Forms.Button();
            this.txtbxAdminPuani = new System.Windows.Forms.TextBox();
            this.txtAdminYili = new System.Windows.Forms.TextBox();
            this.txtAdminFlmİsmi = new System.Windows.Forms.TextBox();
            this.chckbxAdminKomedi = new System.Windows.Forms.CheckBox();
            this.chkbxAdminDram = new System.Windows.Forms.CheckBox();
            this.chkbxAdminMacera = new System.Windows.Forms.CheckBox();
            this.chkbxAdminAksiyon = new System.Windows.Forms.CheckBox();
            this.chkbxAdminGerilim = new System.Windows.Forms.CheckBox();
            this.chkbxAdminKorku = new System.Windows.Forms.CheckBox();
            this.lblAdminTurKomedi = new System.Windows.Forms.Label();
            this.lblAdminTurDram = new System.Windows.Forms.Label();
            this.lblAdminTurMacera = new System.Windows.Forms.Label();
            this.lblAdminTurAksiyon = new System.Windows.Forms.Label();
            this.lblAdminTurGerilim = new System.Windows.Forms.Label();
            this.lblAdminTurKorku = new System.Windows.Forms.Label();
            this.btnAdminFlmEkle = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdminGeriGit = new System.Windows.Forms.Button();
            this.grpbxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxAdmin
            // 
            this.grpbxAdmin.Controls.Add(this.btnAdminGuncelle);
            this.grpbxAdmin.Controls.Add(this.btnAdminSil);
            this.grpbxAdmin.Controls.Add(this.txtbxAdminPuani);
            this.grpbxAdmin.Controls.Add(this.txtAdminYili);
            this.grpbxAdmin.Controls.Add(this.txtAdminFlmİsmi);
            this.grpbxAdmin.Controls.Add(this.chckbxAdminKomedi);
            this.grpbxAdmin.Controls.Add(this.chkbxAdminDram);
            this.grpbxAdmin.Controls.Add(this.chkbxAdminMacera);
            this.grpbxAdmin.Controls.Add(this.chkbxAdminAksiyon);
            this.grpbxAdmin.Controls.Add(this.chkbxAdminGerilim);
            this.grpbxAdmin.Controls.Add(this.chkbxAdminKorku);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurKomedi);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurDram);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurMacera);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurAksiyon);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurGerilim);
            this.grpbxAdmin.Controls.Add(this.lblAdminTurKorku);
            this.grpbxAdmin.Controls.Add(this.btnAdminFlmEkle);
            this.grpbxAdmin.Location = new System.Drawing.Point(12, 40);
            this.grpbxAdmin.Name = "grpbxAdmin";
            this.grpbxAdmin.Size = new System.Drawing.Size(480, 509);
            this.grpbxAdmin.TabIndex = 14;
            this.grpbxAdmin.TabStop = false;
            // 
            // btnAdminGuncelle
            // 
            this.btnAdminGuncelle.Location = new System.Drawing.Point(209, 378);
            this.btnAdminGuncelle.Name = "btnAdminGuncelle";
            this.btnAdminGuncelle.Size = new System.Drawing.Size(107, 29);
            this.btnAdminGuncelle.TabIndex = 35;
            this.btnAdminGuncelle.Text = "Güncelle";
            this.btnAdminGuncelle.UseVisualStyleBackColor = true;
            this.btnAdminGuncelle.Click += new System.EventHandler(this.btnAdminGuncelle_Click);
            // 
            // btnAdminSil
            // 
            this.btnAdminSil.Location = new System.Drawing.Point(334, 378);
            this.btnAdminSil.Name = "btnAdminSil";
            this.btnAdminSil.Size = new System.Drawing.Size(107, 29);
            this.btnAdminSil.TabIndex = 33;
            this.btnAdminSil.Text = "Sil";
            this.btnAdminSil.UseVisualStyleBackColor = true;
            this.btnAdminSil.Click += new System.EventHandler(this.btnAdminSil_Click);
            // 
            // txtbxAdminPuani
            // 
            this.txtbxAdminPuani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxAdminPuani.Location = new System.Drawing.Point(237, 222);
            this.txtbxAdminPuani.Multiline = true;
            this.txtbxAdminPuani.Name = "txtbxAdminPuani";
            this.txtbxAdminPuani.Size = new System.Drawing.Size(204, 24);
            this.txtbxAdminPuani.TabIndex = 32;
            this.txtbxAdminPuani.Text = "İMDB Puanı";
            // 
            // txtAdminYili
            // 
            this.txtAdminYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminYili.Location = new System.Drawing.Point(237, 155);
            this.txtAdminYili.Multiline = true;
            this.txtAdminYili.Name = "txtAdminYili";
            this.txtAdminYili.Size = new System.Drawing.Size(204, 24);
            this.txtAdminYili.TabIndex = 31;
            this.txtAdminYili.Text = "Çıkış Yılı";
            // 
            // txtAdminFlmİsmi
            // 
            this.txtAdminFlmİsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminFlmİsmi.Location = new System.Drawing.Point(237, 84);
            this.txtAdminFlmİsmi.Multiline = true;
            this.txtAdminFlmİsmi.Name = "txtAdminFlmİsmi";
            this.txtAdminFlmİsmi.Size = new System.Drawing.Size(204, 24);
            this.txtAdminFlmİsmi.TabIndex = 27;
            this.txtAdminFlmİsmi.Text = "Film İsmi";
            // 
            // chckbxAdminKomedi
            // 
            this.chckbxAdminKomedi.AutoSize = true;
            this.chckbxAdminKomedi.Location = new System.Drawing.Point(33, 268);
            this.chckbxAdminKomedi.Name = "chckbxAdminKomedi";
            this.chckbxAdminKomedi.Size = new System.Drawing.Size(15, 14);
            this.chckbxAdminKomedi.TabIndex = 26;
            this.chckbxAdminKomedi.UseVisualStyleBackColor = true;
            // 
            // chkbxAdminDram
            // 
            this.chkbxAdminDram.AutoSize = true;
            this.chkbxAdminDram.Location = new System.Drawing.Point(33, 222);
            this.chkbxAdminDram.Name = "chkbxAdminDram";
            this.chkbxAdminDram.Size = new System.Drawing.Size(15, 14);
            this.chkbxAdminDram.TabIndex = 25;
            this.chkbxAdminDram.UseVisualStyleBackColor = true;
            // 
            // chkbxAdminMacera
            // 
            this.chkbxAdminMacera.AutoSize = true;
            this.chkbxAdminMacera.Location = new System.Drawing.Point(33, 177);
            this.chkbxAdminMacera.Name = "chkbxAdminMacera";
            this.chkbxAdminMacera.Size = new System.Drawing.Size(15, 14);
            this.chkbxAdminMacera.TabIndex = 24;
            this.chkbxAdminMacera.UseVisualStyleBackColor = true;
            // 
            // chkbxAdminAksiyon
            // 
            this.chkbxAdminAksiyon.AutoSize = true;
            this.chkbxAdminAksiyon.Location = new System.Drawing.Point(33, 134);
            this.chkbxAdminAksiyon.Name = "chkbxAdminAksiyon";
            this.chkbxAdminAksiyon.Size = new System.Drawing.Size(15, 14);
            this.chkbxAdminAksiyon.TabIndex = 23;
            this.chkbxAdminAksiyon.UseVisualStyleBackColor = true;
            // 
            // chkbxAdminGerilim
            // 
            this.chkbxAdminGerilim.AutoSize = true;
            this.chkbxAdminGerilim.Location = new System.Drawing.Point(33, 89);
            this.chkbxAdminGerilim.Name = "chkbxAdminGerilim";
            this.chkbxAdminGerilim.Size = new System.Drawing.Size(15, 14);
            this.chkbxAdminGerilim.TabIndex = 22;
            this.chkbxAdminGerilim.UseVisualStyleBackColor = true;
            // 
            // chkbxAdminKorku
            // 
            this.chkbxAdminKorku.AutoSize = true;
            this.chkbxAdminKorku.Location = new System.Drawing.Point(33, 46);
            this.chkbxAdminKorku.Name = "chkbxAdminKorku";
            this.chkbxAdminKorku.Size = new System.Drawing.Size(15, 14);
            this.chkbxAdminKorku.TabIndex = 21;
            this.chkbxAdminKorku.UseVisualStyleBackColor = true;
            // 
            // lblAdminTurKomedi
            // 
            this.lblAdminTurKomedi.AutoSize = true;
            this.lblAdminTurKomedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurKomedi.Location = new System.Drawing.Point(82, 263);
            this.lblAdminTurKomedi.Name = "lblAdminTurKomedi";
            this.lblAdminTurKomedi.Size = new System.Drawing.Size(62, 20);
            this.lblAdminTurKomedi.TabIndex = 20;
            this.lblAdminTurKomedi.Text = "Komedi";
            // 
            // lblAdminTurDram
            // 
            this.lblAdminTurDram.AutoSize = true;
            this.lblAdminTurDram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurDram.Location = new System.Drawing.Point(82, 217);
            this.lblAdminTurDram.Name = "lblAdminTurDram";
            this.lblAdminTurDram.Size = new System.Drawing.Size(48, 20);
            this.lblAdminTurDram.TabIndex = 19;
            this.lblAdminTurDram.Text = "Dram";
            // 
            // lblAdminTurMacera
            // 
            this.lblAdminTurMacera.AutoSize = true;
            this.lblAdminTurMacera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurMacera.Location = new System.Drawing.Point(82, 172);
            this.lblAdminTurMacera.Name = "lblAdminTurMacera";
            this.lblAdminTurMacera.Size = new System.Drawing.Size(62, 20);
            this.lblAdminTurMacera.TabIndex = 18;
            this.lblAdminTurMacera.Text = "Macera";
            // 
            // lblAdminTurAksiyon
            // 
            this.lblAdminTurAksiyon.AutoSize = true;
            this.lblAdminTurAksiyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurAksiyon.Location = new System.Drawing.Point(82, 129);
            this.lblAdminTurAksiyon.Name = "lblAdminTurAksiyon";
            this.lblAdminTurAksiyon.Size = new System.Drawing.Size(64, 20);
            this.lblAdminTurAksiyon.TabIndex = 17;
            this.lblAdminTurAksiyon.Text = "Aksiyon";
            // 
            // lblAdminTurGerilim
            // 
            this.lblAdminTurGerilim.AutoSize = true;
            this.lblAdminTurGerilim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurGerilim.Location = new System.Drawing.Point(82, 84);
            this.lblAdminTurGerilim.Name = "lblAdminTurGerilim";
            this.lblAdminTurGerilim.Size = new System.Drawing.Size(58, 20);
            this.lblAdminTurGerilim.TabIndex = 16;
            this.lblAdminTurGerilim.Text = "Gerilim";
            // 
            // lblAdminTurKorku
            // 
            this.lblAdminTurKorku.AutoSize = true;
            this.lblAdminTurKorku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminTurKorku.Location = new System.Drawing.Point(82, 40);
            this.lblAdminTurKorku.Name = "lblAdminTurKorku";
            this.lblAdminTurKorku.Size = new System.Drawing.Size(50, 20);
            this.lblAdminTurKorku.TabIndex = 15;
            this.lblAdminTurKorku.Text = "Korku";
            // 
            // btnAdminFlmEkle
            // 
            this.btnAdminFlmEkle.Location = new System.Drawing.Point(86, 378);
            this.btnAdminFlmEkle.Name = "btnAdminFlmEkle";
            this.btnAdminFlmEkle.Size = new System.Drawing.Size(107, 29);
            this.btnAdminFlmEkle.TabIndex = 14;
            this.btnAdminFlmEkle.Text = "Ekle";
            this.btnAdminFlmEkle.UseVisualStyleBackColor = true;
            this.btnAdminFlmEkle.Click += new System.EventHandler(this.btnAdminFlmEkle_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(509, 12);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(363, 537);
            this.dgvAdmin.TabIndex = 15;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // btnAdminGeriGit
            // 
            this.btnAdminGeriGit.Location = new System.Drawing.Point(12, 11);
            this.btnAdminGeriGit.Name = "btnAdminGeriGit";
            this.btnAdminGeriGit.Size = new System.Drawing.Size(75, 23);
            this.btnAdminGeriGit.TabIndex = 18;
            this.btnAdminGeriGit.Text = "Geri Git";
            this.btnAdminGeriGit.UseVisualStyleBackColor = true;
            this.btnAdminGeriGit.Click += new System.EventHandler(this.btnAdminGeriGit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnAdminGeriGit);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.grpbxAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Recommender";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grpbxAdmin.ResumeLayout(false);
            this.grpbxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxAdmin;
        private System.Windows.Forms.CheckBox chckbxAdminKomedi;
        private System.Windows.Forms.CheckBox chkbxAdminDram;
        private System.Windows.Forms.CheckBox chkbxAdminMacera;
        private System.Windows.Forms.CheckBox chkbxAdminAksiyon;
        private System.Windows.Forms.CheckBox chkbxAdminGerilim;
        private System.Windows.Forms.CheckBox chkbxAdminKorku;
        private System.Windows.Forms.Label lblAdminTurKomedi;
        private System.Windows.Forms.Label lblAdminTurDram;
        private System.Windows.Forms.Label lblAdminTurMacera;
        private System.Windows.Forms.Label lblAdminTurAksiyon;
        private System.Windows.Forms.Label lblAdminTurGerilim;
        private System.Windows.Forms.Label lblAdminTurKorku;
        private System.Windows.Forms.Button btnAdminFlmEkle;
        private System.Windows.Forms.TextBox txtAdminFlmİsmi;
        private System.Windows.Forms.TextBox txtAdminYili;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TextBox txtbxAdminPuani;
        private System.Windows.Forms.Button btnAdminGeriGit;
        private System.Windows.Forms.Button btnAdminSil;
        private System.Windows.Forms.Button btnAdminGuncelle;
    }
}