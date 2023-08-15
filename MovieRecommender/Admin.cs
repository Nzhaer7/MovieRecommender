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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        MovieDbContext movieDbContext = new MovieDbContext();   

        void load()
        {
            dgvAdmin.DataSource = movieDbContext.Movies.ToList();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdminFlmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ChbxChnge();
                movieDbContext.Movies.Add(
                new Movies
                {
                    MovieName = txtAdminFlmİsmi.Text,
                    MovieScore = Convert.ToInt32(txtbxAdminPuani.Text),
                    MovieYear = Convert.ToInt32(txtAdminYili.Text),
                }
                );
                var result = movieDbContext.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    load();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void ChbxChnge()
        {

            if (chckbxAdminKomedi.Checked)
            {
                if(string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Komedi = txtAdminFlmİsmi.Text
                    });
                    
                }
                
            }
            if (chkbxAdminAksiyon.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Aksiyon = txtAdminFlmİsmi.Text
                    });
                   
                }
            }
            if (chkbxAdminDram.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Dram = txtAdminFlmİsmi.Text
                    });
                    
                }
            }
            if (chkbxAdminGerilim.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Gerilim = txtAdminFlmİsmi.Text
                    });
                    
                }
            }
            if (chkbxAdminKorku.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Korku = txtAdminFlmİsmi.Text
                    });
                    
                }
            }
            if (chkbxAdminMacera.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdminFlmİsmi.Text))
                {
                    MessageBox.Show("Önce film ismini girin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieDbContext.Types.Add(
                    new Types
                    {
                        Macera = txtAdminFlmİsmi.Text
                    });
                    
                }
            }
            var result = movieDbContext.SaveChanges();
        }
        private void btnAdminGeriGit_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.ShowDialog();
            this.Close();
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            try
            {
                int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
                var kayıt = movieDbContext.Movies.Find(İd);

                movieDbContext.Movies.Remove(kayıt);
                var result = movieDbContext.SaveChanges();
                if (result > 0)
                    MessageBox.Show("Kayıt başarı ile silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
                var kayıt = movieDbContext.Movies.Find(İd);

                txtAdminFlmİsmi.Text = kayıt.MovieName;
                txtAdminYili.Text = kayıt.MovieYear.ToString();
                txtbxAdminPuani.Text = kayıt.MovieScore.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
                var kayıt = movieDbContext.Movies.Find(İd);

                kayıt.MovieName = txtAdminFlmİsmi.Text;
                kayıt.MovieYear = Convert.ToInt32(txtAdminYili.Text);
                kayıt.MovieScore = Convert.ToInt32(txtbxAdminPuani.Text);

                var result = movieDbContext.SaveChanges();
                if (result > 0)
                    MessageBox.Show("Kayıt başarı ile güncllendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
