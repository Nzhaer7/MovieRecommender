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

        public void chbxChange()
        {
            string prev = "";
            if (chkbxUserAksiyon.Checked)
            {
                foreach(var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Aksiyon.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        prev= item.Aksiyon.ToString();
                        if(prev==item.Aksiyon.ToString())
                        {
                            continue;
                        }
                        else
                        {
                            rtxtBxUser.Text = item.Aksiyon.ToString();
                        }
                    }
                }
            }
            if (chckbxUserKomedi.Checked)
            {
                foreach (var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Komedi.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        if (prev == item.Komedi.ToString())
                        {
                            continue;
                        }
                        else
                        {
                            rtxtBxUser.Text = item.Komedi.ToString();
                            prev = item.Komedi.ToString();
                        }    
                    }
                }
            }
            if (chkbxUserDram.Checked)
            {
                foreach (var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Dram.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        if(prev == item.Dram.ToString())
                        {
                            continue;
                        }
                        else 
                        {
                            rtxtBxUser.Text = item.Dram.ToString();
                            prev = item.Dram.ToString();
                        }
                    }
                }
            }
            if (chkbxUserKorku.Checked)
            {
                foreach (var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Korku.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        if (prev == item.Korku.ToString())
                        {
                            continue;
                        }
                        else
                        {
                            rtxtBxUser.Text = item.Korku.ToString();
                            prev = item.Korku.ToString();
                        }
                    }
                }
            }
            if (chkbxUserMacera.Checked)
            {
                foreach (var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Macera.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        if (prev == item.Macera.ToString())
                        {
                            continue;
                        }
                        else
                        {
                            rtxtBxUser.Text = item.Macera.ToString();
                            prev = item.Macera.ToString();
                        } 
                    }
                }
            }
            if (chkbxUserGerilim.Checked)
            {
                foreach (var item in movieDbContext.Types)
                {
                    if (string.IsNullOrWhiteSpace(item.Gerilim.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        if ( prev == item.Gerilim.ToString())
                        {
                            continue;
                        }
                        else
                        {
                            rtxtBxUser.Text = item.Gerilim.ToString();
                        } 
                    }
                }
            }
        }
        private void btnUserFlmAra_Click(object sender, EventArgs e)
        {
            chbxChange();   
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
