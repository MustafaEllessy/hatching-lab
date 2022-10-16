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
    public partial class HatchingEggsStore : Form
    {
        public HatchingEggsStore()
        {
            InitializeComponent();
        }
        DataTable dtHatchingEggsStore;
        private void frmHatchingEggsStore_Load(object sender, EventArgs e)
        {
            dtHatchingEggsStore = DB.Data("select * from hatchingEggsStore");
            dgvFarmHatchingEggsStore.DataSource = dtHatchingEggsStore;
            dgvFarmHatchingEggsStore.Columns["ID"].Visible = false;
            dgvFarmHatchingEggsStore.ClearSelection();
        }
    }
}
