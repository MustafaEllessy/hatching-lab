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
    public partial class SoledTableEggs : Form
    {
        public SoledTableEggs()
        {
            InitializeComponent();
        }

        DataTable dtTableEggStore;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmTableEggs_Load(object sender, EventArgs e)
        {
            dtTableEggStore = DB.Data("select * from tableEggsStore");

            for (int i = 0; i < dtTableEggStore.Rows.Count; i++)
            {
                dgvTableEggsSoled.Rows.Add(new object[] { dtTableEggStore.Rows[i][2].ToString(), 0, 0, 0, 0, 0, 0 });
                dgvTableEggsStore.Rows.Add(new object[] { dtTableEggStore.Rows[i][2].ToString(), dtTableEggStore.Rows[i][3].ToString(), dtTableEggStore.Rows[i][4].ToString(), dtTableEggStore.Rows[i][5].ToString(), dtTableEggStore.Rows[i][6].ToString(), dtTableEggStore.Rows[i][7].ToString(), dtTableEggStore.Rows[i][8].ToString() });
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
            DB.insertToDB("soledTableEggs", new string[] { "sellDate", "stationName", "bigEggsCount", "msh3rEggs", "middleEggsCount", "smallEggsCount", "brokenEggsCount", "rottenEggsCount"}, sellData);
        }
        public void updateEggsStore(DataGridViewRow dr)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string EggsCount1 = dr.Cells[1].Value.ToString();
            string EggsCount2 = dr.Cells[2].Value.ToString();
            string EggsCount3 = dr.Cells[3].Value.ToString();
            string EggsCount4 = dr.Cells[4].Value.ToString();
            string EggsCount5 = dr.Cells[5].Value.ToString();
            string EggsCount6 = dr.Cells[6].Value.ToString();
            if (EggsCount1 == "0" && EggsCount2 == "0" && EggsCount3 == "0" && EggsCount4 == "0" && EggsCount5 == "0" && EggsCount6 == "0" )
            {
                return;
            }

            DB.affectBuild("update tableEggsStore set lastUpdate='" + dtExportDate.Value.ToString("dd/MM/yyyy") + "', bigEggsCount=" + EggsCount1 + ", msh3rEggs=" + EggsCount2 + ", middleEggsCount=" + EggsCount3 + ", smallEggsCount=" + EggsCount4 + ", brokenEggsCount=" + EggsCount5 + ", rottenEggsCount=" + EggsCount6 + " where stationName='" + stationName + "';");

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
                    DataGridViewRow dr = dgvTableEggsSoled.Rows[row1[i]];
                    DataGridViewRow dr2 = dgvTableEggsStore.Rows[row1[i]];
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
            int takenValue1 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[1].Value.ToString());
            int takenValue2 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[2].Value.ToString());
            int takenValue3 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[3].Value.ToString());
            int takenValue4 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[4].Value.ToString());
            int takenValue5 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[5].Value.ToString());
            int takenValue6 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[6].Value.ToString());
            int storeValue1 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            int storeValue2 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[2].Value.ToString());
            int storeValue3 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[3].Value.ToString());
            int storeValue4 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[4].Value.ToString());
            int storeValue5 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[5].Value.ToString());
            int storeValue6 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[6].Value.ToString());
       
            if (takenValue1 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue1 + takenValue1;
            }
          
            if (takenValue2 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[2].Value = storeValue2 + takenValue2;
            }
           
            if (takenValue3 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[3].Value = storeValue3 + takenValue3;
            }
       
            if (takenValue4 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[4].Value = storeValue4 + takenValue4;
            }
          
            if (takenValue5 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[5].Value = storeValue5+ takenValue5;
            }
          
            if (takenValue6 > 0)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[6].Value = storeValue6 + takenValue6;
            }
            
        }

        private void dgvTableEggs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          
            int takenValue1 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[1].Value.ToString());
            int takenValue2 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[2].Value.ToString());
            int takenValue3 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[3].Value.ToString());
            int takenValue4 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[4].Value.ToString());
            int takenValue5 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[5].Value.ToString());
            int takenValue6 = Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[6].Value.ToString());
            int storeValue1 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[1].Value.ToString());
            int storeValue2 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[2].Value.ToString());
            int storeValue3 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[3].Value.ToString());
            int storeValue4 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[4].Value.ToString());
            int storeValue5 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[5].Value.ToString());
            int storeValue6 = Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[6].Value.ToString());

            if (takenValue1 < 0 )
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[1].Value = 0;
                return;
            }
            if (takenValue2 < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[2].Value = 0;
                return;
            }
            if (takenValue3 < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[3].Value = 0;
                return;
            }
            if (takenValue4 < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[4].Value = 0;
                return;
            }
            if (takenValue5 < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[5].Value = 0;
                return;
            }
            if (takenValue6 < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[6].Value = 0;
                return;
            }
            if (Convert.ToInt32(dgvTableEggsStore.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)- Convert.ToInt32(dgvTableEggsSoled.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0)
            {
                dgvTableEggsSoled.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                MessageBox.Show("لا يوجد رصيد بيض كافً");
                return;
            }
            if (takenValue1 <= storeValue1)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[1].Value = storeValue1 - takenValue1;
            }
            if (takenValue2 <= storeValue2)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[2].Value = storeValue2 - takenValue2;
            }
            if (takenValue3 <= storeValue3)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[3].Value = storeValue3 - takenValue3;
            }
            if (takenValue4 <= storeValue4)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[4].Value = storeValue4 - takenValue4;
            }
            if (takenValue5 <= storeValue5)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[5].Value = storeValue5 - takenValue5;
            }
            if (takenValue6 <= storeValue6)
            {
                dgvTableEggsStore.Rows[e.RowIndex].Cells[6].Value = storeValue6 - takenValue6;
            }
            else
            {
                MessageBox.Show("لا يوجد بيض كافً");
                dgvTableEggsStore.Rows[e.RowIndex].Cells[1].Value = 0;
                dgvTableEggsStore.Rows[e.RowIndex].Cells[2].Value = 0;
                dgvTableEggsStore.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvTableEggsStore.Rows[e.RowIndex].Cells[4].Value = 0;
                dgvTableEggsStore.Rows[e.RowIndex].Cells[5].Value = 0;
                dgvTableEggsStore.Rows[e.RowIndex].Cells[6].Value = 0;
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
