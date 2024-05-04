using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Event_scheduling_planning_system
{
    public partial class MainForm : Form
    {
        OracleConnection conn;
        string ordb = "Data source  = orcl ; user id = event; password = 123";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            LogIn_page.BringToFront();
            Start_page.BringToFront();

            homePageBody.Controls.Add(new EventCard());
            homePageBody.Controls.Add(new EventCard());
            homePageBody.Controls.Add(new EventCard());
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Start_page.Hide();
            timer1.Enabled = false;
        }

        #region LogInPage

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            int userId;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "Login";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("Uname", username1_txb.Text.ToString());
            c.Parameters.Add("Upass", password1_txb.Text.ToString());

            c.Parameters.Add("U_id", OracleDbType.Int32 , ParameterDirection.Output);


            try { 

                c.ExecuteNonQuery();
                //Console.WriteLine("Username :" + username1_txb.Text + " >>>   Pass : " + password1_txb.Text);

                userId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString());
                Home_page.BringToFront();
            
            }
            catch {

                MessageBox.Show("Wrong Username or password");
            }

        }
        public  int getUSerId()
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            int userId;
            c.CommandText = "getUserId";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("U_id", OracleDbType.Int32, ParameterDirection.Output);

            try
            {

                c.ExecuteNonQuery();
                //Console.WriteLine("Username :" + username1_txb.Text + " >>>   Pass : " + password1_txb.Text);

                userId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString());
                return userId + 1;

            }
            catch
            {
               return 1;
            }
        }
        private void signUp_btn_Click(object sender, EventArgs e)
        {
            SignUp_page.BringToFront();
        }

        #endregion

        #region RegisterPage

        private void create_acc_btn_Click(object sender, EventArgs e)
        {
            if (password2_txb.Text != confirm_pass_txb.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "Insert into users values (:Id , :Username , :Email , :Password )";
            c.CommandType = CommandType.Text;


            int nextId = getUSerId();

            c.Parameters.Add("Id", nextId);
            c.Parameters.Add("Username", username2_txb.Text.ToString());
            c.Parameters.Add("Email", email_txb.Text.ToString());
            c.Parameters.Add("password", password2_txb.Text.ToString());

            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
              Home_page.BringToFront();
            }
            else
                MessageBox.Show("Something went worng");
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
