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
    public partial class ImportHatchingEggsForHatchingProcess : Form
    {
        public ImportHatchingEggsForHatchingProcess()
        {
            InitializeComponent();
        }
        DataTable dtHatchingEggsStore;
        public static List<DataGridViewRow> insertRows = new List<DataGridViewRow>();
        public static List<DataGridViewRow> updateRows = new List<DataGridViewRow>();
        public static int EggsCount;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmPullHatchingEggsForHatching_Load(object sender, EventArgs e)
        {
            dtHatchingEggsStore = DB.Data("select * from hatchingEggsStore");
            for (int i = 0; i < dtHatchingEggsStore.Rows.Count; i++)
            {
                dgvHatchingEggsStore.Rows.Add(new object[] { dtHatchingEggsStore.Rows[i][2].ToString(), dtHatchingEggsStore.Rows[i][3].ToString() });
                dgvHachingEggsForProcess.Rows.Add(new object[] { dtHatchingEggsStore.Rows[i][2].ToString(), 0 });
            }
            dgvHatchingEggsStore.ClearSelection();
            dgvHachingEggsForProcess.ClearSelection();
        }
        List<int> rowIndex = new List<int>();

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
                if (row1.Count == 0)
                {
                    MessageBox.Show("لم يتم إدخال بيانات");
                    return;
                }
                for (int i = 0; i < row1.Count; i++)
                {
                    DataGridViewRow dr = dgvHachingEggsForProcess.Rows[row1[i]];
                    DataGridViewRow dr2 = dgvHatchingEggsStore.Rows[row1[i]];
                    insertRows.Add(dr);
                    updateRows.Add(dr2);
                }
                DialogResult dresult = MessageBox.Show("تابع");
                if (dresult == DialogResult.OK)
                {
                    EggsCount =Convert.ToInt32( txtEggsCount.Text);
                    this.Close();
                    HatchingProcess frm = new HatchingProcess();
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم الحفظ");
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTableEggs_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int takenValue = Convert.ToInt32(dgvHachingEggsForProcess.Rows[e.RowIndex].Cells[1].Value.ToString());
            int storeValue = Convert.ToInt32(dgvHatchingEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue > 0)
            {
                dgvHatchingEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue + takenValue;
            }
            else
            {
                dgvHachingEggsForProcess.Rows[e.RowIndex].Cells[1].Value = 0;
            }
        }
        private void dgvTableEggs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int takenValue = Convert.ToInt32(dgvHachingEggsForProcess.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue < 0)
            {
                dgvHachingEggsForProcess.Rows[e.RowIndex].Cells[1].Value = 0;
                return;
            }

            int storeValue = Convert.ToInt32(dgvHatchingEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue <= storeValue)
            {
                dgvHatchingEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue - takenValue;
            }
            else
            {
                MessageBox.Show("لا يوجد بيض كافً");
                dgvHachingEggsForProcess.Rows[e.RowIndex].Cells[1].Value = 0;
                return;
            }
            int eggs = 0;
            for (int i = 0; i < dgvHachingEggsForProcess.Rows.Count; i++)
            {
                eggs += Convert.ToInt32(dgvHachingEggsForProcess.Rows[i].Cells[1].Value.ToString());
            }
            txtEggsCount.Text = eggs + "";
            rowIndex.Add(e.RowIndex);
        }
        bool firstLoad = true;
        private void ImportHatchingEggsForHatchingProcess_Resize(object sender, EventArgs e)
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
