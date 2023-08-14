using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRecommender
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblAdiminSifremiUnuttum_Click(object sender, EventArgs e)
        {
            PasChange pasChange = new PasChange();
            this.Hide();
            pasChange.ShowDialog();
            this.Close();
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
            this.Close();
        }

        private void btnLoginGeriGit_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.ShowDialog();
            this.Close();
        }

        MovieDbContext movieDbContext = new MovieDbContext();
        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            foreach (var data in movieDbContext.Users)          
            { 
                if (txtbxLoginKullaniciAdi.Text == data.UserName && txtbxLoginSifre.Text == data.Password)
                {
                    Admin admin = new Admin();
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yanlış bilgi girdiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void chkbxLoginSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxLoginSifreGoster.Checked) 
            { 
                txtbxLoginSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxLoginSifre.UseSystemPasswordChar = true;

            }
        }
    }
}
