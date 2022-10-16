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
    public partial class DisplayHatchingProccess : Form
    {
        DataTable dtHatchingEggs;
        public DisplayHatchingProccess()
        {
            InitializeComponent();
        }

        private void frmHatchingLabDisplay_Load(object sender, EventArgs e)
        {
            dtHatchingEggs = DB.Data("select * from hatchingEggs");
            dgvHatchingEggs.DataSource = dtHatchingEggs;
            dgvHatchingEggs.Columns["ID"].Visible = false;
            dgvHatchingEggs.ClearSelection();

            dgvHatchingEggs.Columns["colStart"].DisplayIndex = 0;
            dgvHatchingEggs.Columns["colHatchingDate"].DisplayIndex = 1;
            dgvHatchingEggs.Columns["colEggs"].DisplayIndex = 2;
            dgvHatchingEggs.Columns["colPercent"].DisplayIndex = 3;
            dgvHatchingEggs.Columns["colChicks"].DisplayIndex = 4;
            dgvHatchingEggs.Columns["colLayehCount"].DisplayIndex = 5;

            dgvHatchingEggs.Sort(dgvHatchingEggs.Columns["colStart"], ListSortDirection.Descending);
        }
    }
}
