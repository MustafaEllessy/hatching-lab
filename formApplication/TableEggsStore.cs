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
    public partial class TableEggsStore : Form
    {
        DataTable dtEggs;
        public TableEggsStore()
        {
            InitializeComponent();
        }

        private void frmEggsStore_Load(object sender, EventArgs e)
        {
            dtEggs = DB.Data("select * from tableEggsStore");
            dgvTableEggsStore.DataSource = dtEggs;
            dgvTableEggsStore.Columns["ID"].Visible = false;
            dgvTableEggsStore.ClearSelection();
        }

        private void dgvTableEggsStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
