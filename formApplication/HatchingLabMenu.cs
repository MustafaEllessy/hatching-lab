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
    public partial class HatchingLabMenu : Form
    {
       
        public HatchingLabMenu()
        {
            InitializeComponent();
        }

        private void pnlHatchingProcess_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                ImportHatchingEggsForHatchingProcess frm = new ImportHatchingEggsForHatchingProcess();
                frm.ShowDialog();
            }
            else
            {
                DisplayHatchingProccess frm = new DisplayHatchingProccess();
                frm.ShowDialog();
            }
        }

        private void pnlTableEggs_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                TableEggs frm = new TableEggs();
                frm.ShowDialog();
            }
            else
            {
                frmTableEggsDisplay frm = new frmTableEggsDisplay();
                frm.ShowDialog();
            }
        }

        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmHatching_Load(object sender, EventArgs e)
        {
            frmMode = 0;
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;
      
        }

        private void pnlFarmEggsStore_Click(object sender, EventArgs e)
        {
            TableEggsStore frm = new TableEggsStore();
            frm.ShowDialog();
        }

        private void pnlFarmEggs_Click(object sender, EventArgs e)
        {
            if(frmMode==0 )
            {
                ImportEggs frm = new ImportEggs();
                frm.ShowDialog();
            }
            else
            {
                DisplayImportedEggs frm = new DisplayImportedEggs();
                frm.ShowDialog();
            }
        }

        private void pnlImportedHatching_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                ImportHatchingEggs frm = new ImportHatchingEggs();
                frm.ShowDialog();
            }
            else
            {
                DisplayImportedHatchingEggs frm = new DisplayImportedHatchingEggs();
                frm.ShowDialog();
            }
        }

        private void pnlHatchingEggsSells_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                SoledHatchingEggs frm = new SoledHatchingEggs();
                frm.ShowDialog();
            }
            else
            {
                DisplaySoledHatchingEggs frm = new DisplaySoledHatchingEggs();
                frm.ShowDialog();
            }
        }

        private void pnlHatchingEggs_Click(object sender, EventArgs e)
        {
            HatchingEggsStore frm = new HatchingEggsStore();
            frm.ShowDialog();
        }
        bool firstLoad = true;
        private void HatchingLabMenu_Resize(object sender, EventArgs e)
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
        int frmMode = 0;
        private void pnlView_Click(object sender, EventArgs e)
        {
            frmMode = 1;
            panel1.BackgroundImage = formApplication.Properties.Resources.عرض;

        }

        private void pnlEnter_Click(object sender, EventArgs e)
        {
            frmMode = 0;
            panel1.BackgroundImage = formApplication.Properties.Resources.ادخال;
        }

        private void S(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            formApplication.Reports frm = new formApplication.Reports();
            frm.ShowDialog();
        }

        private void pnlSoledTableEggs_Click(object sender, EventArgs e)
        {
            if (frmMode == 0)
            {
                SoledTableEggs frm = new SoledTableEggs();
                frm.ShowDialog();
            }
            else
            {
                DisplaySoledTableEggs frm = new DisplaySoledTableEggs();
                frm.ShowDialog();
            }
        }
    }
}
