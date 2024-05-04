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
        int currentUserId;
        OracleConnection conn;
        public static string ordb = "Data source  = orcl ; user id = event; password = 123";
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

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "Login";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("Uname", username1_txb.Text.ToString());
            c.Parameters.Add("Upass", password1_txb.Text.ToString());

            c.Parameters.Add("U_id", OracleDbType.Int32, ParameterDirection.Output);


            try
            {

                c.ExecuteNonQuery();
                currentUserId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString());
                DisplayHomePage();
            }
            catch
            {
                MessageBox.Show("Wrong Username or password");
            }

        }
        public int getUSerId()
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "getUserId";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("U_id", OracleDbType.Int32, ParameterDirection.Output);

            try
            {
                c.ExecuteNonQuery();
                currentUserId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString()) + 1;
                return currentUserId;
            }
            catch
            {
                currentUserId = 1;
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
                DisplayHomePage();
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
            AddEventForm currEvent = new AddEventForm(currentUserId);
            currEvent.ShowDialog();
            if(currEvent.eventAdded) DisplayEvents("displayEventsByStartDate");
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            homePageBody.Controls.Clear();
            LogIn_page.BringToFront();
        }

        public void DisplayEvents(string procedureName)
        {
            homePageBody.Controls.Clear();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = procedureName;
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("currId", currentUserId);
            c.Parameters.Add("Data", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {

                EventCard card = new EventCard(
                    dr["EVENTNAME"].ToString(),
                    dr["EVENTLOCATION"].ToString(),
                    dr["STARTDATETIME"].ToString(),
                    dr["ENDDATETIME"].ToString(),
                    dr["REMINDERDATETIME"].ToString(),
                    dr["EVENTSTATUS"].ToString()
                    );
                homePageBody.Controls.Add(card);
            }
            dr.Close();
        }

        public void DisplayHomePage()
        {
            DisplayEvents("displayEventsByStartDate");
            Home_page.BringToFront();
        }

        #endregion

        private void doneFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("filterDoneEvents");
        }
    }
}
