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
    public partial class DisplayImportedHatchingEggs : Form
    {
        public DisplayImportedHatchingEggs()
        {
            InitializeComponent();
        }
        DataTable dtImportedHatchingEggs;
        private void DisplayImportedHatchingEggs_Load(object sender, EventArgs e)
        {
            dtImportedHatchingEggs = DB.Data("select * from ImportedHatchingEggs");
            dgvImportedHatchingEggs.DataSource = dtImportedHatchingEggs;
            dgvImportedHatchingEggs.Columns["ID"].Visible = false;
            dgvImportedHatchingEggs.ClearSelection();
        }
    }
}
