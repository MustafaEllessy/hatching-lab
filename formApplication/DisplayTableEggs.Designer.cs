namespace formApplication
{
    partial class frmTableEggsDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTableEggs = new System.Windows.Forms.DataGridView();
            this.colSortDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBigEggsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleEggsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSmallEggs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableEggs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableEggs
            // 
            this.dgvTableEggs.AllowUserToAddRows = false;
            this.dgvTableEggs.AllowUserToDeleteRows = false;
            this.dgvTableEggs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableEggs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableEggs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableEggs.ColumnHeadersHeight = 50;
            this.dgvTableEggs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTableEggs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSortDate,
            this.colStationName,
            this.colBigEggsCount,
            this.Column3,
            this.colMiddleEggsCount,
            this.colSmallEggs,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableEggs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTableEggs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableEggs.EnableHeadersVisualStyles = false;
            this.dgvTableEggs.Location = new System.Drawing.Point(0, 0);
            this.dgvTableEggs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTableEggs.MultiSelect = false;
            this.dgvTableEggs.Name = "dgvTableEggs";
            this.dgvTableEggs.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableEggs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTableEggs.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTableEggs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTableEggs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTableEggs.RowTemplate.Height = 60;
            this.dgvTableEggs.Size = new System.Drawing.Size(1285, 674);
            this.dgvTableEggs.TabIndex = 12;
            // 
            // colSortDate
            // 
            this.colSortDate.DataPropertyName = "sellDate";
            dataGridViewCellStyle2.Format = "D";
            this.colSortDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSortDate.HeaderText = "تاريخ الفرز";
            this.colSortDate.MinimumWidth = 6;
            this.colSortDate.Name = "colSortDate";
            this.colSortDate.ReadOnly = true;
            this.colSortDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSortDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStationName
            // 
            this.colStationName.DataPropertyName = "stationName";
            this.colStationName.HeaderText = "اسم المحطة";
            this.colStationName.MinimumWidth = 6;
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            // 
            // colBigEggsCount
            // 
            this.colBigEggsCount.DataPropertyName = "bigEggsCount";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colBigEggsCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBigEggsCount.FillWeight = 90F;
            this.colBigEggsCount.HeaderText = "العتاقى";
            this.colBigEggsCount.MinimumWidth = 6;
            this.colBigEggsCount.Name = "colBigEggsCount";
            this.colBigEggsCount.ReadOnly = true;
            this.colBigEggsCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBigEggsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "msh3rEggs";
            this.Column3.HeaderText = "المشعر";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // colMiddleEggsCount
            // 
            this.colMiddleEggsCount.DataPropertyName = "middleEggsCount";
            this.colMiddleEggsCount.FillWeight = 90F;
            this.colMiddleEggsCount.HeaderText = "الوسط";
            this.colMiddleEggsCount.MinimumWidth = 6;
            this.colMiddleEggsCount.Name = "colMiddleEggsCount";
            this.colMiddleEggsCount.ReadOnly = true;
            this.colMiddleEggsCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMiddleEggsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSmallEggs
            // 
            this.colSmallEggs.DataPropertyName = "smallEggsCount";
            this.colSmallEggs.FillWeight = 90F;
            this.colSmallEggs.HeaderText = "البشاير";
            this.colSmallEggs.MinimumWidth = 6;
            this.colSmallEggs.Name = "colSmallEggs";
            this.colSmallEggs.ReadOnly = true;
            this.colSmallEggs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSmallEggs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "brokenEggsCount";
            this.Column1.FillWeight = 85F;
            this.Column1.HeaderText = "المكسور";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rottenEggsCount";
            this.Column2.FillWeight = 85F;
            this.Column2.HeaderText = "المعدم";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmTableEggsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvTableEggs);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTableEggsDisplay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض بيض المائدة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEggsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableEggs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableEggs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSmallEggs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleEggsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBigEggsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSortDate;
    }
}