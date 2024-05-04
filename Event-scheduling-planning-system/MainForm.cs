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

            LogIn_page.BringToFront();
            Start_page.BringToFront();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Start_page.Hide();
            timer1.Enabled = false;
        }

        #region LogInPage

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            Home_page.BringToFront();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            SignUp_page.BringToFront();
        }

        #endregion

        #region RegisterPage

        private void create_acc_btn_Click(object sender, EventArgs e)
        {
            Home_page.BringToFront();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            LogIn_page.BringToFront();
        }

        #endregion

        #region HomePage
        private void addEvent_btn_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddEventForm());
            //AddEventForm addEventForm = new AddEventForm();
            //addEventForm.ShowDialog();
            (new AddEventForm()).ShowDialog();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            LogIn_page.BringToFront();
        }

        #endregion

    }
}
