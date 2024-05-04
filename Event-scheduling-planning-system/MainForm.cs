using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_scheduling_planning_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddEventForm());
            //AddEventForm addEventForm = new AddEventForm();
            (new AddEventForm()).ShowDialog();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {

        }

        private void create_acc_btn_Click(object sender, EventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
