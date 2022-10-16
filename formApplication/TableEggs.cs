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
    public partial class TableEggs : Form
    {
        public TableEggs()
        {
            InitializeComponent();
        }

        DataTable dtEggStore;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmTableEggs_Load(object sender, EventArgs e)
        {


            dtEggStore = DB.Data("select * from EggsStore");
            for (int i = 0; i < dtEggStore.Rows.Count; i++)
            {
                dgvEggsStore.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), dtEggStore.Rows[i][3].ToString() });
                dgvTableEggs.Rows.Add(new object[] { dtEggStore.Rows[i][2].ToString(), 0,0, 0, 0, 0, 0 });
            }

        }
 

       
        List<int> rowIndex = new List<int>();
        public void addExportedEggs(DataGridViewRow dr)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string Attaki = dr.Cells[1].Value.ToString();
            string msh3r = dr.Cells[2].Value.ToString();
            string wasat = dr.Cells[3].Value.ToString();
            string bshayer = dr.Cells[4].Value.ToString();
            string kaser = dr.Cells[5].Value.ToString();
            string moadem = dr.Cells[6].Value.ToString();
            int EggsCount = Convert.ToInt32(Attaki) + Convert.ToInt32(msh3r) + Convert.ToInt32(wasat) + Convert.ToInt32(bshayer) + Convert.ToInt32(kaser) + Convert.ToInt32(moadem);
            if (EggsCount==0)
            {
                return;
            }
            string exportDate = dtExportDate.Value.ToString("dd/MM/yyyy");
            object[] sellData = new object[] { exportDate, stationName, Convert.ToInt32(Attaki), Convert.ToInt32(msh3r), Convert.ToInt32(wasat), Convert.ToInt32(bshayer), Convert.ToInt32(kaser), Convert.ToInt32(moadem) };
            DB.insertToDB("tableEggs", new string[] { "sellDate", "stationName", "bigEggsCount", "msh3rEggs", "middleEggsCount", "smallEggsCount", "brokenEggsCount", "rottenEggsCount"}, sellData);
            DataTable dtTableEggs = DB.Data("select * from tableEggsStore");
            if(stationName=="محطة 3")
            {
                DB.affectBuild("update tableEggsStore set lastUpdate='" + dtExportDate.Value.ToString("dd/MM/yyyy") +
           "', bigEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[0][3].ToString()) + Convert.ToInt32(Attaki)) +
           ", msh3rEggs=" + (Convert.ToInt32(dtTableEggs.Rows[0][4].ToString()) + Convert.ToInt32(msh3r)) +
           ", middleEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[0][5].ToString()) + Convert.ToInt32(wasat)) +
           ", smallEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[0][6].ToString()) + Convert.ToInt32(bshayer)) +
           ", brokenEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[0][7].ToString()) + Convert.ToInt32(kaser)) +
           ", rottenEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[0][8].ToString()) + Convert.ToInt32(moadem)) +
           " where stationName='" + stationName + "';");
            }
            else
            {
                DB.affectBuild("update tableEggsStore set lastUpdate='" + dtExportDate.Value.ToString("dd/MM/yyyy") +
           "', bigEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[1][3].ToString()) + Convert.ToInt32(Attaki)) +
           ", msh3rEggs=" + (Convert.ToInt32(dtTableEggs.Rows[1][4].ToString()) + Convert.ToInt32(msh3r)) +
           ", middleEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[1][5].ToString()) + Convert.ToInt32(wasat)) +
           ", smallEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[1][6].ToString()) + Convert.ToInt32(bshayer)) +
           ", brokenEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[1][7].ToString()) + Convert.ToInt32(kaser)) +
           ", rottenEggsCount=" + (Convert.ToInt32(dtTableEggs.Rows[1][8].ToString()) + Convert.ToInt32(moadem)) +
           " where stationName='" + stationName + "';");
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
                for (int i = 0; i < row1.Count; i++)
                {
                    DataGridViewRow dr = dgvTableEggs.Rows[row1[i]];
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
            int takenValue = Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[1].Value.ToString())
                + Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[2].Value.ToString())
                + Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[3].Value.ToString()) +
                Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[4].Value.ToString()) +
                Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[5].Value.ToString());

            int storeValue = Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (takenValue > 0)
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue + takenValue;
            }
          
        }

        private void dgvTableEggs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int takenValue = Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[1].Value.ToString())
                + Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[2].Value.ToString())
                + Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[3].Value.ToString()) +
                Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[4].Value.ToString()) +
                Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[5].Value.ToString()) +
                Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[6].Value.ToString())
                ;

            int storeValue = Convert.ToInt32(dgvEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[1].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[1].Value = 0;
                return;

            }
              if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[2].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[2].Value = 0;
                return;

            }
             if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[3].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[3].Value = 0;
                return;

            }
             if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[4].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[4].Value = 0;
                return;
            }
             if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[5].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[5].Value = 0;
                return;

            }
             if (Convert.ToInt32(dgvTableEggs.Rows[e.RowIndex].Cells[6].Value.ToString()) < 0)
            {
                dgvTableEggs.Rows[e.RowIndex].Cells[6].Value = 0;
                return;

            }
            if (takenValue <= storeValue)
            {
                dgvEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue - takenValue;
            }
            else
            {
                MessageBox.Show("لا يوجد بيض كافً");
                dgvTableEggs.Rows[e.RowIndex].Cells[1].Value = 0;
                dgvTableEggs.Rows[e.RowIndex].Cells[2].Value = 0;
                dgvTableEggs.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvTableEggs.Rows[e.RowIndex].Cells[4].Value = 0;
                dgvTableEggs.Rows[e.RowIndex].Cells[5].Value = 0;
                dgvTableEggs.Rows[e.RowIndex].Cells[6].Value = 0;
                return;
            }
            rowIndex.Add(e.RowIndex);
        }
        bool firstLoad = true;
        private void TableEggs_Resize(object sender, EventArgs e)
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

        private void dgvTableEggs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
