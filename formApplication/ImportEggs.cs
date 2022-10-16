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
    public partial class ImportEggs : Form
    {
        public ImportEggs()
        {
            InitializeComponent();
        }

        private void txtEggsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        DataTable dtEggStore;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmImportedEggs_Load(object sender, EventArgs e)
        {
            dtEggStore = DB.Data("select * from EggsStore");
            for (int i = 0; i < dtEggStore.Rows.Count; i++)
            {
                dgvEggsStore.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), dtEggStore.Rows[i][3].ToString() });
                dgvImport.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), 0 });
            }
            dgvEggsStore.ClearSelection();
            dgvImport.ClearSelection();
        }
        private void dgvImport_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
       
            if (Convert.ToInt32(dgvImport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 0)
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                (Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) -
                Convert.ToInt32(dgvImport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }

        }
        private void dgvImport_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {      
            try
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                (Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) +
                Convert.ToInt32(dgvImport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rowIndex.Add(e.RowIndex);
        }
        List<int> rowIndex = new List<int>();
        public void addImportedEggs(DataGridViewRow dr)
        {

            string stationName = dr.Cells[0].Value.ToString();
            string EggsCount = dr.Cells[1].Value.ToString();
            if(EggsCount=="0")
            {
                return;
            }
            string ImportDateEggs = dtImportTime.Value.ToString("dd/MM/yyyy");   
            object[] stationData = new object[] { ImportDateEggs, stationName,Convert.ToInt32( EggsCount) };
            DB.insertToDB("ImportedEggs", new string[] { "ImportDate", "StationsName", "EggsCount" }, stationData);
        }
        public void updateEggsStore(DataGridViewRow dr)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string EggsCount = dr.Cells[1].Value.ToString();
            if (EggsCount == "0")
            {
                return;
            }

            DB.affectBuild("update EggsStore set lastUpdate='" + dtImportTime.Value.ToString("dd/MM/yyyy") + "', EggsCount=" + EggsCount +  " where stationName='" + stationName + "';");
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<int> row1 = rowIndex.Distinct().ToList();
                for (int i = 0; i < row1.Count; i++)
                {
                    DataGridViewRow dr = dgvImport.Rows[row1[i]];
                    DataGridViewRow dr2 = dgvEggsStore.Rows[row1[i]];
                    addImportedEggs(dr);
                    updateEggsStore(dr2);
                }
                MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم الحفظ");
                MessageBox.Show(ex.Message);
            }
          
        }

        private void dgvImport_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvImport_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
        }
        bool firstLoad = true;
        private void ImportEggs_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this, controlsDetails, controlsResult);
                firstLoad = false;
            }
            ResizeForm.changeControls(this, controlsResult);
        }
    }
}
