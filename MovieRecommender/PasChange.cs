using System;
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
    public partial class PasChange : Form
    {
        public PasChange()
        {
            InitializeComponent();
        }

        private void btnPasChangeChange_Click(object sender, EventArgs e)
        {
            grpbxPasChange.Visible = true;
        }
    }
}
