using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Event_scheduling_planning_system
{
    public partial class CrystalReportForm : Form
    {
        CrystalReport1 cr;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();

            foreach (ParameterDiscreteValue paramter in cr.ParameterFields[0].DefaultValues)
                userid_cmb.Items.Add(paramter.Value);

        }

        private void generateReport_btn_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, userid_cmb.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
