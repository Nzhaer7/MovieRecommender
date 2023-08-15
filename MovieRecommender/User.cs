using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRecommender
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnUserGeriGit_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.ShowDialog();
            this.Close();
        }

        MovieDbContext movieDbContext = new MovieDbContext();

        public string[] chbxChange()
        {
            string[] results = new string[0];
            if (chkbxUserAksiyon.Checked)
            {
                results.Append(lblUserTurAksiyon.Text.ToString());
            }
            if (chckbxUserKomedi.Checked)
            {
                results.Append(lblUserTurKomedi.Text.ToString());
            }
            if (chkbxUserDram.Checked)
            {
                results.Append(lblUserTurDram.Text.ToString());
            }
            if (chkbxUserKorku.Checked)
            {
                results.Append(lblUserTurKorku.Text.ToString());
            }
            if (chkbxUserMacera.Checked)
            {
                results.Append(lblUserTurMacera.Text.ToString());
            }
            if (chkbxUserGerilim.Checked)
            {
                results.Append(lblUserTurGerilim.Text.ToString());
            }
            return results;
        }
        private void btnUserFlmAra_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
