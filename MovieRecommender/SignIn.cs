using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.XPath;

namespace MovieRecommender
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        MovieDbContext movieDbContext = new MovieDbContext();
        Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        public string Sifre()
        {
            string result;
            if (txtbxSignInSifre.Text==txtbxSignInSifreTekrar.Text)
            {
                if (validateGuidRegex.IsMatch(txtbxSignInSifre.Text.ToString()))
                {
                    result = txtbxSignInSifre.Text.ToString();
                    return result;
                }
                else 
                {
                    MessageBox.Show("Hatalı formatta şifre girdiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0";
                }
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            

        }
        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            if (Sifre() != "0")
            {
                movieDbContext.Users.Add(
                new Users
                {
                   UserName = txtbxSignInKullaniciAdi.Text,
                   Password = Sifre()
                }

                );
                var result = movieDbContext.SaveChanges();
                if(result>0)
                MessageBox.Show("Başarı ile kayıt olundu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            
        }

        private void btnSignInGeriGit_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtbxSignInSifre.PasswordChar = '*';
            txtbxSignInSifreTekrar.PasswordChar = '*';
        }
    }
}
