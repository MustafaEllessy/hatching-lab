using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApplication
{
    public partial class DisplaySoledHatchingEggs : Form
    {
        public DisplaySoledHatchingEggs()
        {
            InitializeComponent();
        }
        DataTable dtSoledHatching;
        private void frmSoledHatchingDisplay_Load(object sender, EventArgs e)
        {
            dtSoledHatching = DB.Data("select * from soledHatching");
            dgvSoledHatchingEggs.DataSource = dtSoledHatching;
            dgvSoledHatchingEggs.Columns["ID"].Visible = false;
            dgvSoledHatchingEggs.ClearSelection();
        }
    }
}
