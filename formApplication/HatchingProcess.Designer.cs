namespace formApplication
{
    partial class HatchingProcess
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
            this.dtEnterEngineDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtHatchingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLayehEggCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSolalat = new System.Windows.Forms.TextBox();
            this.lblChicksCount = new System.Windows.Forms.Label();
            this.txtEggsCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsh3r = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFayoumi = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtEnterEngineDate
            // 
            this.dtEnterEngineDate.Location = new System.Drawing.Point(224, 22);
            this.dtEnterEngineDate.Name = "dtEnterEngineDate";
            this.dtEnterEngineDate.Size = new System.Drawing.Size(245, 39);
            this.dtEnterEngineDate.TabIndex = 47;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(452, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(442, 49);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtHatchingDate
            // 
            this.dtHatchingDate.Location = new System.Drawing.Point(1027, 22);
            this.dtHatchingDate.Name = "dtHatchingDate";
            this.dtHatchingDate.Size = new System.Drawing.Size(245, 39);
            this.dtHatchingDate.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(886, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "تاريخ الفقس";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "تاريخ الدخول للمكنة";
            // 
            // txtLayehEggCount
            // 
            this.txtLayehEggCount.Location = new System.Drawing.Point(576, 105);
            this.txtLayehEggCount.Name = "txtLayehEggCount";
            this.txtLayehEggCount.Size = new System.Drawing.Size(97, 39);
            this.txtLayehEggCount.TabIndex = 2;
            this.txtLayehEggCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLayehEggCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSmall_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "البيض اللايح";
            // 
            // txtSolalat
            // 
            this.txtSolalat.Location = new System.Drawing.Point(68, 52);
            this.txtSolalat.Name = "txtSolalat";
            this.txtSolalat.Size = new System.Drawing.Size(307, 39);
            this.txtSolalat.TabIndex = 58;
            this.txtSolalat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSolalat.TextChanged += new System.EventHandler(this.txtChickCount_TextChanged);
            this.txtSolalat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSmall_KeyPress);
            // 
            // lblChicksCount
            // 
            this.lblChicksCount.AutoSize = true;
            this.lblChicksCount.Location = new System.Drawing.Point(381, 55);
            this.lblChicksCount.Name = "lblChicksCount";
            this.lblChicksCount.Size = new System.Drawing.Size(129, 33);
            this.lblChicksCount.TabIndex = 56;
            this.lblChicksCount.Text = "عدد الكتاكيت";
            // 
            // txtEggsCount
            // 
            this.txtEggsCount.BackColor = System.Drawing.Color.White;
            this.txtEggsCount.Location = new System.Drawing.Point(850, 105);
            this.txtEggsCount.Name = "txtEggsCount";
            this.txtEggsCount.ReadOnly = true;
            this.txtEggsCount.Size = new System.Drawing.Size(97, 39);
            this.txtEggsCount.TabIndex = 50;
            this.txtEggsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEggsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSmall_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 33);
            this.label9.TabIndex = 53;
            this.label9.Text = "إجمالى البيض";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(390, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 185);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMsh3r);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مشعر";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 33);
            this.label3.TabIndex = 60;
            this.label3.Text = "عدد الكتاكيت";
            // 
            // txtMsh3r
            // 
            this.txtMsh3r.Location = new System.Drawing.Point(41, 54);
            this.txtMsh3r.Name = "txtMsh3r";
            this.txtMsh3r.Size = new System.Drawing.Size(307, 39);
            this.txtMsh3r.TabIndex = 62;
            this.txtMsh3r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtFayoumi);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "فيومى";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "عدد الكتاكيت";
            // 
            // txtFayoumi
            // 
            this.txtFayoumi.Location = new System.Drawing.Point(72, 54);
            this.txtFayoumi.Name = "txtFayoumi";
            this.txtFayoumi.Size = new System.Drawing.Size(307, 39);
            this.txtFayoumi.TabIndex = 62;
            this.txtFayoumi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblChicksCount);
            this.tabPage3.Controls.Add(this.txtSolalat);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(575, 141);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "سلالات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HatchingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLayehEggCount);
            this.Controls.Add(this.txtEggsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtHatchingDate);
            this.Controls.Add(this.dtEnterEngineDate);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HatchingProcess";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مكنة التفريخ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHatchingLab_Load);
            this.Resize += new System.EventHandler(this.HatchingProcess_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtEnterEngineDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtHatchingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLayehEggCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSolalat;
        private System.Windows.Forms.Label lblChicksCount;
        private System.Windows.Forms.TextBox txtEggsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsh3r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFayoumi;
    }
}