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
    public partial class HatchingProcess : Form
    {
        public HatchingProcess()
        {
            InitializeComponent();
        }

        private void txtSmall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmHatchingLab_Load(object sender, EventArgs e)
        {

            txtEggsCount.Text = ImportHatchingEggsForHatchingProcess.EggsCount+"";
        }
        public void addExportedEggs(DataGridViewRow dr ,int processID)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string eggsCount = dr.Cells[1].Value.ToString();
            int EggsCount = Convert.ToInt32(eggsCount);
            if (EggsCount == 0)
            {
                return;
            }
            object[] hatchingData = new object[] {  stationName, EggsCount, processID };
            DB.insertToDB("importedHatchingEggsForHatching", new string[] { "stationName", "hatchingCount", "hatchingProcessID" }, hatchingData);
        }
        public void updateEggsStore(DataGridViewRow dr)
        {
            string stationName = dr.Cells[0].Value.ToString();
            string EggsCount = dr.Cells[1].Value.ToString();

            DB.affectBuild("update HatchingEggsStore set lastUpdate='" + dtEnterEngineDate.Value.ToString("dd/MM/yyyy") + "', EggsCount=" + EggsCount + " where stationName='" + stationName + "';");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (DateTime.Compare(dtEnterEngineDate.Value, dtHatchingDate.Value) >= 0)
                {
                    MessageBox.Show("لا يمكن أن يكون تاريخ البدأ قبل او نفس تاريخ الإنتهاء");
                    return;
                }
                if ( txtEggsCount.Text == "" || txtLayehEggCount.Text == "" || txtSolalat.Text == "" || txtFayoumi.Text == ""|| txtMsh3r.Text == "")
                {
                    MessageBox.Show("املأ البيانات الفارغة ");
                    return;
                }
                int eggCount = ImportHatchingEggsForHatchingProcess.EggsCount;


                string hachingPercent = (Convert.ToDecimal(txtLayehEggCount.Text) / Convert.ToDecimal(txtEggsCount.Text))+"";// txtHatchingPercent.Text+ " فى المئة";
               
                string  chickTypeAndCount ="مشعر -> " + txtMsh3r.Text +", ";
                chickTypeAndCount += "سلالات -> " + txtSolalat.Text + ", ";
                chickTypeAndCount += "فيومى -> " + txtFayoumi.Text + ".";
                int layehEggCount =Convert.ToInt32( txtLayehEggCount.Text);
                DB.insertToDB("hatchingEggs", new string[] { "enteranceDate", "EggsCount", "hatchingPercent", "hatchingDate", "chickTypeAndCount", "LayehEggsCount" },
                                              new object[] { dtEnterEngineDate.Value.ToString("yyyy/MM/dd"),eggCount,hachingPercent, dtHatchingDate.Value.ToString("yyyy/MM/dd"), chickTypeAndCount,layehEggCount });

                int hatchingID = Convert.ToInt32(DB.Data("select * from hatchingLastID").Rows[0][0].ToString());
                //inserting data about hatching eggs 
                for (int i = 0; i < ImportHatchingEggsForHatchingProcess.insertRows.Count; i++)
                {
                    addExportedEggs(ImportHatchingEggsForHatchingProcess.insertRows[i],hatchingID);
                    updateEggsStore (ImportHatchingEggsForHatchingProcess.updateRows[i]);
                }   
                    MessageBox.Show("تم الحفظ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد مشكلة فى الإدخال");
                MessageBox.Show(ex.Message);
            }
         
            
        }

        private void x(object sender, EventArgs e)
        {

        }
        bool firstLoad = true;
        private void HatchingProcess_Resize(object sender, EventArgs e)
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

        private void txtChickCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
