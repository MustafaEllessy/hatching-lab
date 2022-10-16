﻿using Microsoft.Reporting.WinForms;
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
    public partial class Reports : Form
    {
       
        public Reports()
        {
            InitializeComponent();
        }

        private void pnlHenFarm_Click(object sender, EventArgs e)
        {
            DataTable tblShow = new DataTable();
            tblShow = DB.Data("select * from  byadDeadCountThatMonth ");
            ReportDataSource rds = new ReportDataSource("DataSet1", tblShow);
            Report1 frm = new Report1();
            frm.reportViewer2.LocalReport.DataSources.Clear();
            frm.reportViewer2.LocalReport.DataSources.Add(rds);
            frm.reportViewer2.LocalReport.Refresh();
            frm.ShowDialog();
        }

        private void pnlEggFarm_Click(object sender, EventArgs e)
        {
            
        }
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();

        private void frmFarms_Load(object sender, EventArgs e)
        {

        }
        bool firstLoad = true;
        private void FarmsMenu_Resize(object sender, EventArgs e)
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

        private void panel1_Click(object sender, EventArgs e)
        {
            DataTable tblShow = new DataTable();
            string query = "";
            string dsName = "";
            if (Convert.ToInt32(((Panel)sender).Tag) == 1)
            {
                query = "select * from  EggsThatImported ";
                dsName = "ds1";
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 2)
            {
                query = "select * from  HatchingThatSoled ";
                dsName = "ds2";
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 3)
            {
                query = "select * from  HatchingEggsThatImported ";
                dsName = "ds3";
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 4)
            {
                query = "select * from  tableEggsType ";
                dsName = "ds4";
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 5)
            {
                query = "select * from  EggsStore ";
                dsName = "ds5";
            }
            else
            {
                query = "select * from  hatchingEggsStore ";
                dsName = "ds6";
            }
          
            tblShow = DB.Data(query);
            ReportDataSource rds = new ReportDataSource(dsName, tblShow);
            if (Convert.ToInt32(((Panel)sender).Tag) == 1)
            {
                Report1 frm = new Report1();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 2)
            {
                Report2 frm = new Report2();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 3)
            {
                Report3 frm = new Report3();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 4)
            {
                Report4 frm = new Report4();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 5)
            {
                Report5 frm = new Report5();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
            else if (Convert.ToInt32(((Panel)sender).Tag) == 6)
            {
                Report6 frm = new Report6();
                frm.reportViewer2.LocalReport.DataSources.Clear();
                frm.reportViewer2.LocalReport.DataSources.Add(rds);
                frm.reportViewer2.LocalReport.Refresh();
                frm.ShowDialog();
            }
        
        }
    }
}
