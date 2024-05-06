
namespace Event_scheduling_planning_system
{
    partial class CrystalReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.userid_cmb = new System.Windows.Forms.ComboBox();
            this.userid_label = new System.Windows.Forms.Label();
            this.generateReport_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 84);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(967, 501);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // userid_cmb
            // 
            this.userid_cmb.FormattingEnabled = true;
            this.userid_cmb.Location = new System.Drawing.Point(64, 26);
            this.userid_cmb.Name = "userid_cmb";
            this.userid_cmb.Size = new System.Drawing.Size(121, 21);
            this.userid_cmb.TabIndex = 1;
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Location = new System.Drawing.Point(12, 29);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(41, 13);
            this.userid_label.TabIndex = 2;
            this.userid_label.Text = "User Id";
            // 
            // generateReport_btn
            // 
            this.generateReport_btn.Location = new System.Drawing.Point(703, 26);
            this.generateReport_btn.Name = "generateReport_btn";
            this.generateReport_btn.Size = new System.Drawing.Size(163, 39);
            this.generateReport_btn.TabIndex = 3;
            this.generateReport_btn.Text = "Generate Report";
            this.generateReport_btn.UseVisualStyleBackColor = true;
            this.generateReport_btn.Click += new System.EventHandler(this.generateReport_btn_Click);
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 597);
            this.Controls.Add(this.generateReport_btn);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.userid_cmb);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.Load += new System.EventHandler(this.CrystalReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox userid_cmb;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Button generateReport_btn;
    }
}