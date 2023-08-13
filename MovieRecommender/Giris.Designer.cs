namespace MovieRecommender
{
    partial class Giris
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
            this.btnAdminForm = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminForm
            // 
            this.btnAdminForm.Location = new System.Drawing.Point(61, 95);
            this.btnAdminForm.Name = "btnAdminForm";
            this.btnAdminForm.Size = new System.Drawing.Size(158, 81);
            this.btnAdminForm.TabIndex = 0;
            this.btnAdminForm.Text = "Admin";
            this.btnAdminForm.UseVisualStyleBackColor = true;
            this.btnAdminForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Location = new System.Drawing.Point(265, 95);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(158, 81);
            this.btnUserForm.TabIndex = 1;
            this.btnUserForm.Text = "User";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnAdminForm);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Recommender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminForm;
        private System.Windows.Forms.Button btnUserForm;
    }
}

