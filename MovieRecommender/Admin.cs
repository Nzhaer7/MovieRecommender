﻿using System;
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
                    MovieType = Convert.ToString(ChbxChnge()),
                    MovieName = txtAdminFlmİsmi.Text,
                    MovieScore = Convert.ToInt32(txtbxAdminPuani.Text),
                    MovieYear = Convert.ToInt32(txtAdminYili.Text),
                }
                );
            var result = movieDbContext.SaveChanges();
            if (result > 0)
            {
                load();
                MessageBox.Show("Kayıt Eklendi");
            }
        }
        public ArrayList ChbxChnge()
        {
            ArrayList results = new ArrayList();
            if (chckbxAdminKomedi.Checked)
            {
                results.Add(lblAdminTurKomedi.Text);
            }
            else if(chkbxAdminAksiyon.Checked)
            {
                results.Add(lblAdminTurAksiyon.Text);
            }
            else if (chkbxAdminDram.Checked)
            {
                results.Add(lblAdminTurDram.Text);
            }
            else if(chkbxAdminGerilim.Checked)
            {
                results.Add(lblAdminTurGerilim.Text);
            }
            else if(chkbxAdminKorku.Checked)
            {
                results.Add(lblAdminTurKorku.Text);
            }
            else if(chkbxAdminMacera.Checked)
            {
                results.Add(lblAdminTurMacera.Text);
            }
            Convert.ToString(results);
            return results;
        }
    }
}
