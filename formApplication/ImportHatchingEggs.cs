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
    public partial class ImportHatchingEggs : Form
    {
        public ImportHatchingEggs()
        {
            InitializeComponent();
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmEportedHatchingEggs_Load(object sender, EventArgs e)
        {
            dtEggStore = DB.Data("select * from EggsStore");
            for (int i = 0; i < dtEggStore.Rows.Count; i++)
            {
                dgvEggsStore.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), dtEggStore.Rows[i][3].ToString() });
                dgvHatchingEggs.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), 0 });
            }
            dgvEggsStore.ClearSelection();
            dgvHatchingEggs.ClearSelection();
        }
        DataTable dtEggStore;

        List<int> rowIndex = new List<int>();
        public void addExportedEggs(DataGridViewRow dr)
        {

            string stationName = dr.Cells[0].Value.ToString();
            string eggsCount = dr.Cells[1].Value.ToString();

            int EggsCount = Convert.ToInt32(eggsCount);
            if (EggsCount == 0)
            { 
                return;
            }
            string exportDate = dtExportDate.Value.ToString("dd/MM/yyyy");
            DB.insertToDB("ImportedHatchingEggs", new string[] { "importDate","stationName", "eggsCount" }, new object[] { exportDate,stationName, eggsCount });
            DataTable dtHatchingEggsStore = DB.Data("select * from  hatchingEggsStore");
            for (int i = 0; i < dtHatchingEggsStore.Rows.Count; i++)
            {   
                if(dtHatchingEggsStore.Rows[i][2].ToString() == stationName)
                {
                    int newEggsCount = EggsCount + Convert.ToInt32(dtHatchingEggsStore.Rows[i][3].ToString());
                    DB.affectBuild("update hatchingEggsStore set lastUpdate='" + exportDate + "', EggsCount=" + newEggsCount + " where stationName='" + stationName + "';");
                    return;
                }
            }
        }
        public void updateEggsStore(DataGridViewRow dr)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string EggsCount = dr.Cells[1].Value.ToString();
            if (EggsCount == "0")
            {
                return;
            }

            DB.affectBuild("update EggsStore set lastUpdate='" + dtExportDate.Value.ToString("dd/MM/yyyy") + "', EggsCount=" + EggsCount + " where stationName='" + stationName + "';");
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvTableEggs_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
        }

        private void dgvTableEggs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> row1 = rowIndex.Distinct().ToList();
                if(row1.Count == 0)
                {
                    MessageBox.Show("لم يتم إدخال بيانات");
                    return;
                }
                for (int i = 0; i < row1.Count; i++)
                {
                    DataGridViewRow dr = dgvHatchingEggs.Rows[row1[i]];
                    DataGridViewRow dr2 = dgvEggsStore.Rows[row1[i]];
                    addExportedEggs(dr);
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

        private void dgvTableEggs_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int takenValue = Convert.ToInt32(dgvHatchingEggs.Rows[e.RowIndex].Cells[1].Value.ToString());
            int storeValue = Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue > 0)
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue + takenValue;
            }
            else
            {
                dgvHatchingEggs.Rows[e.RowIndex].Cells[1].Value = 0;
            }
        }

        private void dgvTableEggs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int takenValue = Convert.ToInt32(dgvHatchingEggs.Rows[e.RowIndex].Cells[1].Value.ToString());

            if (takenValue < 0)
            {
                dgvHatchingEggs.Rows[e.RowIndex].Cells[1].Value = 0;
                return;
            }
            int storeValue = Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue < storeValue)
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue - takenValue;
            }
            else
            {
                MessageBox.Show("لا يوجد بيض كافً");
                dgvHatchingEggs.Rows[e.RowIndex].Cells[1].Value = 0;

                return;
            }
            rowIndex.Add(e.RowIndex);
        }
        bool firstLoad = true;
        private void ImportHatchingEggs_Resize(object sender, EventArgs e)
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

        private void dgvHatchingEggs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
