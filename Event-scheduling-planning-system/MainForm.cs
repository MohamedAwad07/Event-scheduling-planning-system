﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Event_scheduling_planning_system
{
    public partial class MainForm : Form
    {
        int currentUserId;
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder command;
        DataSet ds;
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
            if(username1_txb.Text == "Admin" && password1_txb.Text == "123")
            {
                admin_page.BringToFront();
                return;
            }

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
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email_txb.Text, pattern))
            {
                MessageBox.Show("Invalid email format");
                return;
            }
            
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "Insert into users values (:Id , :Username , :Email , :Password )";
            c.CommandType = CommandType.Text;


            int nextId = getUSerId();
            if(email_txb.Text.ToString() == "")
            {
                MessageBox.Show("Email can not be empty !");
                return;
            }
            else if (username2_txb.Text.ToString() == "")
            {
                MessageBox.Show("Username can not be empty !");
                return;
            }
            else if(password2_txb.Text.ToString() == "")
            {
                MessageBox.Show("Password can not be empty !");
                return;
            }

            c.Parameters.Add("Id", nextId);
            c.Parameters.Add("Username", username2_txb.Text.ToString());
            c.Parameters.Add("Email", email_txb.Text.ToString());
            c.Parameters.Add("password", password2_txb.Text.ToString());
            int r;
            try
            {
                 r = c.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Email already exist , try anohter one");
                return;
            }

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
            AddEventForm currEvent = new AddEventForm(currentUserId , conn);
            currEvent.ShowDialog();
            if (currEvent.eventAdded) DisplayEvents("displayEventsByStartDate");
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
                    dr["EVENTSTATUS"].ToString(),
                    conn,
                    Convert.ToInt32(dr["EVENTID"].ToString())
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

        private void reminderDateFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("filterByReminder");
        }

        private void startDateFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("displayEventsByStartDate");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admin_search_btn_Click(object sender, EventArgs e)
        {

            if (admin_start_DT.Value > admin_end_DT.Value)
            {
                MessageBox.Show("selected date is not valid");
                return;
            }
            string cmdstr = @"SELECT   
                              USERID , EVENTNAME , EVENTLOCATION ,  STARTDATETIME , ENDDATETIME  , EVENTID
                              FROM EVENTS 
                              WHERE 
                              STARTDATETIME >= :startDate AND
                              ENDDATETIME <= :endDate
                                ";

            adapter = new OracleDataAdapter(cmdstr, MainForm.ordb);
            adapter.SelectCommand.Parameters.Add("startDate", admin_start_DT.Value);
            adapter.SelectCommand.Parameters.Add("endDate", admin_end_DT.Value);

            ds = new DataSet();

            adapter.Fill(ds);
            ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["EVENTID"] };
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[5].Visible = false;
        }

        private void admin_save_btn_Click(object sender, EventArgs e)
        {
            command = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
