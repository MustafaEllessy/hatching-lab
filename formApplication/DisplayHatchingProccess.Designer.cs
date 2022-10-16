namespace formApplication
{
    partial class DisplayHatchingProccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHatchingEggs = new System.Windows.Forms.DataGridView();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHatchingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEggs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLayehCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHatchingEggs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHatchingEggs
            // 
            this.dgvHatchingEggs.AllowUserToAddRows = false;
            this.dgvHatchingEggs.AllowUserToDeleteRows = false;
            this.dgvHatchingEggs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHatchingEggs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHatchingEggs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHatchingEggs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHatchingEggs.ColumnHeadersHeight = 70;
            this.dgvHatchingEggs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHatchingEggs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStart,
            this.colHatchingDate,
            this.colEggs,
            this.colPercent,
            this.colChicks,
            this.colLayehCount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHatchingEggs.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHatchingEggs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHatchingEggs.EnableHeadersVisualStyles = false;
            this.dgvHatchingEggs.Location = new System.Drawing.Point(0, 0);
            this.dgvHatchingEggs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHatchingEggs.MultiSelect = false;
            this.dgvHatchingEggs.Name = "dgvHatchingEggs";
            this.dgvHatchingEggs.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHatchingEggs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHatchingEggs.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHatchingEggs.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHatchingEggs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHatchingEggs.RowTemplate.Height = 60;
            this.dgvHatchingEggs.Size = new System.Drawing.Size(1285, 674);
            this.dgvHatchingEggs.TabIndex = 17;
            // 
            // colStart
            // 
            this.colStart.DataPropertyName = "enteranceDate";
            dataGridViewCellStyle2.Format = "D";
            this.colStart.DefaultCellStyle = dataGridViewCellStyle2;
            this.colStart.FillWeight = 125F;
            this.colStart.HeaderText = "تاريخ البدء";
            this.colStart.MinimumWidth = 6;
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHatchingDate
            // 
            this.colHatchingDate.DataPropertyName = "hatchingDate";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colHatchingDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHatchingDate.FillWeight = 125F;
            this.colHatchingDate.HeaderText = "تاريخ الفقس";
            this.colHatchingDate.MinimumWidth = 6;
            this.colHatchingDate.Name = "colHatchingDate";
            this.colHatchingDate.ReadOnly = true;
            this.colHatchingDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHatchingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEggs
            // 
            this.colEggs.DataPropertyName = "EggsCount";
            this.colEggs.HeaderText = "عدد البيض";
            this.colEggs.MinimumWidth = 6;
            this.colEggs.Name = "colEggs";
            this.colEggs.ReadOnly = true;
            // 
            // colPercent
            // 
            this.colPercent.DataPropertyName = "hatchingPercent";
            this.colPercent.FillWeight = 80F;
            this.colPercent.HeaderText = "نسبة التفريخ";
            this.colPercent.MinimumWidth = 6;
            this.colPercent.Name = "colPercent";
            this.colPercent.ReadOnly = true;
            this.colPercent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colChicks
            // 
            this.colChicks.DataPropertyName = "chickTypeAndCount";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colChicks.DefaultCellStyle = dataGridViewCellStyle4;
            this.colChicks.FillWeight = 90F;
            this.colChicks.HeaderText = "نوع وعدد الكتاكيت";
            this.colChicks.MinimumWidth = 6;
            this.colChicks.Name = "colChicks";
            this.colChicks.ReadOnly = true;
            // 
            // colLayehCount
            // 
            this.colLayehCount.DataPropertyName = "LayehEggsCount";
            this.colLayehCount.FillWeight = 80F;
            this.colLayehCount.HeaderText = " البيض اللايح";
            this.colLayehCount.MinimumWidth = 6;
            this.colLayehCount.Name = "colLayehCount";
            this.colLayehCount.ReadOnly = true;
            // 
            // DisplayHatchingProccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 674);
            this.Controls.Add(this.dgvHatchingEggs);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DisplayHatchingProccess";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض معمل التفريخ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHatchingLabDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHatchingEggs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHatchingEggs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLayehCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEggs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHatchingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
    }
}