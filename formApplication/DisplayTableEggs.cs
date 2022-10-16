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
    public partial class frmTableEggsDisplay : Form
    {
        DataTable dtTableEggs;
        public frmTableEggsDisplay()
        {
            InitializeComponent();
        }

        private void frmEggsDisplay_Load(object sender, EventArgs e)
        {
            dtTableEggs = DB.Data("select * from tableEggs");
            dgvTableEggs.DataSource = dtTableEggs;
            dgvTableEggs.Columns["ID"].Visible = false;
            dgvTableEggs.ClearSelection();
        }
    }
}
