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
            
            movieDbContext.Movies.Add(
                new Movies
                {
                    MovieType = ChbxChnge(),
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
        public string ChbxChnge()
        {
            string results="";

            if (chckbxAdminKomedi.Checked)
            {
                results+=lblAdminTurKomedi.Text+",";
            }
            if(chkbxAdminAksiyon.Checked)
            {
                results += lblAdminTurAksiyon.Text + ",";
            }
            if (chkbxAdminDram.Checked)
            {
                results += lblAdminTurDram.Text + ",";
            }
            if(chkbxAdminGerilim.Checked)
            {
                results += lblAdminTurGerilim.Text + ",";
            }
            if(chkbxAdminKorku.Checked)
            {
                results += lblAdminTurKorku.Text + ",";
            }
            if(chkbxAdminMacera.Checked)
            {
                results += lblAdminTurMacera.Text + ",";
            }
            Convert.ToString(results);

            return results;
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
            int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
            var kayıt = movieDbContext.Movies.Find(İd);

            movieDbContext.Movies.Remove(kayıt);
            var result = movieDbContext.SaveChanges();
            if (result > 0)
                MessageBox.Show("Kayıt başarı ile silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();

        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
            var kayıt = movieDbContext.Movies.Find(İd);

            txtAdminFlmİsmi.Text=kayıt.MovieName;
            txtAdminYili.Text=kayıt.MovieYear.ToString();
            txtbxAdminPuani.Text=kayıt.MovieScore.ToString();

        }

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            int İd = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value);
            var kayıt = movieDbContext.Movies.Find(İd);

            kayıt.MovieName = txtAdminFlmİsmi.Text;
            kayıt.MovieYear = Convert.ToInt32(txtAdminYili.Text);
            kayıt.MovieScore = Convert.ToInt32(txtbxAdminPuani.Text);

            var result = movieDbContext.SaveChanges();
            if (result > 0)
                MessageBox.Show("Kayıt başarı ile güncllendi","", MessageBoxButtons.OK,MessageBoxIcon.Information);
                load();
        }
    }
}
