using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Event_scheduling_planning_system
{
    public partial class MainForm : Form
    {
        public static int userId;
        public static OracleConnection conn;
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
                userId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString());
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
                userId = Convert.ToInt32(c.Parameters["U_id"].Value.ToString()) + 1;
                return userId;
            }
            catch
            {
                userId = 1;
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
            AddEventForm currEvent = new AddEventForm();
            currEvent.ShowDialog();
            if (currEvent.eventAdded) DisplayEvents("displayEventsByStartDate");
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            homePageBody.Controls.Clear();
            LogIn_page.BringToFront();
            Stack_handling.redo_stack.Clear();
            Stack_handling.undo_stack.Clear();
        }

        public void DisplayEvents(string procedureName)
        {
            homePageBody.Controls.Clear();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = procedureName;
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("currId", userId);
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
                    Convert.ToInt32(dr["EVENTID"].ToString()),
                    homePageBody
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

        private void doneFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("filterDoneEvents");
            label3.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void reminderDateFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("filterByReminder");
            label2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
        }

        private void startDateFilter_btn_Click(object sender, EventArgs e)
        {
            DisplayEvents("displayEventsByStartDate");
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
        }


        #endregion

        #region Admin page
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

        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "UPDATE EVENTS SET EventStatus = 'done' WHERE EndDateTime <= SYSDATE AND EVENTSTATUS = 'new' ";
            c.CommandType = CommandType.Text;

            int r =  c.ExecuteNonQuery();

            if(r != -1)
            {
                Console.WriteLine("no of affected rows : " + r);
            }
            else
                Console.WriteLine("ERRRRRRRRRRRRRROR");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_page.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn_page.BringToFront();
        }

        private void email_txb_TextChanged(object sender, EventArgs e)
        {

        }

        void deleteTextWhenTap(System.Windows.Forms.TextBox textField , string defaultText , bool isChange)
        {
            if (isChange == true) textField.Text = "";
            else  textField.Text = defaultText;
        }

        private void email_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(email_txb , "Email" , true);

            deleteTextWhenTap(username2_txb , username2_txb.Text , false);
            deleteTextWhenTap(password2_txb , password2_txb.Text, false);
            deleteTextWhenTap(confirm_pass_txb , confirm_pass_txb.Text, false);

        }

        private void username2_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(username2_txb , "Username" , true);

            deleteTextWhenTap(email_txb, email_txb.Text, false);
            deleteTextWhenTap(password2_txb, password2_txb.Text, false);
            deleteTextWhenTap(confirm_pass_txb, confirm_pass_txb.Text, false);
        }

        private void password2_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(password2_txb , "Password" , true);

            deleteTextWhenTap(email_txb, email_txb.Text, false);
            deleteTextWhenTap(username2_txb, username2_txb.Text, false);
            deleteTextWhenTap(confirm_pass_txb, confirm_pass_txb.Text, false);
        }

        private void confirm_pass_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(confirm_pass_txb , "Confirm Password" , true);

            deleteTextWhenTap(email_txb, email_txb.Text, false);
            deleteTextWhenTap(password2_txb, password2_txb.Text, false);
            deleteTextWhenTap(username2_txb, username2_txb.Text, false);
        }

        //Login
        private void username1_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(username1_txb, "Username", true);
            deleteTextWhenTap(password1_txb, password1_txb.Text, false);
        }

        private void password1_txb_Click(object sender, EventArgs e)
        {
            deleteTextWhenTap(password1_txb, "123", true);
            deleteTextWhenTap(username1_txb, username1_txb.Text, false);
        }

        private void eye_close1_Click(object sender, EventArgs e)
        {
            eye_open1.BringToFront();
            password1_txb.UseSystemPasswordChar = false;
        }

        private void eye_open1_Click_1(object sender, EventArgs e)
        {
            eye_close1.BringToFront();
            password1_txb.UseSystemPasswordChar = true;
        }

        private void eye_close2_Click(object sender, EventArgs e)
        {
            eye_open2.BringToFront();
            password2_txb.UseSystemPasswordChar = false;
        }

        private void eye_open2_Click(object sender, EventArgs e)
        {
            eye_close2.BringToFront();
            password2_txb.UseSystemPasswordChar = true;
        }

        private void eye_open3_Click(object sender, EventArgs e)
        {
            eye_close3.BringToFront();
            confirm_pass_txb.UseSystemPasswordChar = true;
        }

        private void eye_close3_Click(object sender, EventArgs e)
        {
            eye_open3.BringToFront();
            confirm_pass_txb.UseSystemPasswordChar = false;
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            Stack_handling.undo();
            DisplayEvents("displayEventsByStartDate");
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            Stack_handling.redo();
            DisplayEvents("displayEventsByStartDate");
        }

        private void viewReport_btn_Click(object sender, EventArgs e)
        {
            CrystalReportForm crf = new CrystalReportForm();
            crf.ShowDialog();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            admin_page.BringToFront();
        }

        private void crystal_btn_Click(object sender, EventArgs e)
        {
            CrystalReportForm crf = new CrystalReportForm();
            crf.ShowDialog();
        }
    }
}
