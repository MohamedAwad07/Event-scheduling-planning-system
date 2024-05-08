
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

    public partial class AddEventForm : Form
    {
      
        int eventId;
        DateTime startdate;
        DateTime enddate;
        DateTime reminderTime;
        public bool eventAdded = false;
        bool editMode = false;

        Stack_Event eventToPush;

        FlowLayoutPanel homePageBody;
      
        public AddEventForm()
        {
            InitializeComponent();
            done_checkbox.Visible = false;
        }

        public AddEventForm( string name,  string location,  string startDate,  string endDate,  string reminderDate,  string status, int eventId, FlowLayoutPanel homePageBody)
        {
            InitializeComponent();
            eventName_txb.Text = name;
            eventLocation_txb.Text = location;
            start_DT.Text = startDate;
            end_DT.Text = endDate;
            reminder_DT.Text = reminderDate;
            done_checkbox.Checked = status == "done" ? true : false;
            this.eventId = eventId;
            editMode = true;
            this.homePageBody = homePageBody;
       
             eventToPush = new Stack_Event
                   (
                   Stack_Event.Actions.EDIT,
                   eventId,
                   eventName_txb.Text.ToString(),
                   eventLocation_txb.Text.ToString(),
                   Convert.ToDateTime(startDate),
                   Convert.ToDateTime(endDate),
                   Convert.ToDateTime(reminderDate),
                   done_checkbox.Checked ? "done" : "new"
                   );
         
        }

        private void saveEvent_btn_Click(object sender, EventArgs e)
        {

            if (validateDate() == false) return;

            if(editMode)
            {
                edit();
                return;
            }   
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;


            c.CommandText = "Insert into EVENTS values (:Id , :name , :startdate , :enddate , :reminderDate , :eventLocation , :status , :userId)";
            c.CommandType = CommandType.Text;


            getEventId();

            c.Parameters.Add("Id", eventId);
            c.Parameters.Add("name", eventName_txb.Text.ToString());
            c.Parameters.Add("startdate", startdate);
            c.Parameters.Add("enddate", enddate);
            c.Parameters.Add("reminderDate", reminderTime);
            c.Parameters.Add("eventLocation", eventLocation_txb.Text.ToString());
            c.Parameters.Add("status", "new");
            c.Parameters.Add("userId", MainForm.userId);


            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Event added successfully");
                eventAdded = true;

                Stack_Event events = new Stack_Event
                (
                Stack_Event.Actions.ADD,
                eventId,
                eventName_txb.Text.ToString(),
                eventLocation_txb.Text.ToString(),
                Convert.ToDateTime(startdate),
                Convert.ToDateTime(enddate),
                Convert.ToDateTime(reminderTime),
                "new"
                );
                Stack_handling.saveAction(events);
                Stack_handling.redo_stack.Clear();
                this.Close();
            }
            else
                MessageBox.Show("Something went worng");


        }
        public void DisplayEvents(string procedureName)
        {
            homePageBody.Controls.Clear();
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandText = procedureName;
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("currId", MainForm.userId);
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
                    ); ;
                homePageBody.Controls.Add(card);
            }
            dr.Close();
        }
        private void edit()
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;


            c.CommandType = CommandType.Text;
            c.CommandText =
                @"
                    UPDATE EVENTS SET
                    EVENTNAME = :name ,
                    EVENTLOCATION = :loc ,
                    STARTDATETIME =  :startdate ,
                    ENDDATETIME =  :enddate ,
                    REMINDERDATETIME = :reminder,
                    EVENTSTATUS = :status 
                    WHERE EVENTID = :id
                ";

            c.Parameters.Add("name", eventName_txb.Text);
            c.Parameters.Add("loc", eventLocation_txb.Text);
            c.Parameters.Add("startdate", startdate);
            c.Parameters.Add("enddate", enddate);
            c.Parameters.Add("reminder", reminderTime);
            c.Parameters.Add("status", done_checkbox.Checked ? "done" : "new");
            c.Parameters.Add("id", eventId);


            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Event updated successfully");
                Stack_handling.saveAction(eventToPush);
                Stack_handling.redo_stack.Clear();
                DisplayEvents("displayEventsByStartDate");
                this.Close();
            }
            else
                MessageBox.Show("Something went worng");
        }

        public void getEventId()
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandText = "getEventId";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("EID", OracleDbType.Int32, ParameterDirection.Output);

            try
            {
                c.ExecuteNonQuery();
                eventId = Convert.ToInt32(c.Parameters["EID"].Value.ToString()) + 1;
            }
            catch
            {
                eventId = 1;
            }
        }

        private bool validateDate()
        {
            if (eventName_txb.Text == "")
            {
                MessageBox.Show("please enter event name");
                return false;
            }
            else if (eventLocation_txb.Text == "")
            {
                MessageBox.Show("please enter event Location");
                return false;
            }


            startdate = start_DT.Value;
            enddate = end_DT.Value;
            reminderTime = reminder_DT.Value;

            if (enddate < startdate)
            {
                MessageBox.Show("End date can not be before the start date");
                return false;
            }
            //else if (reminderTime < startdate)
            //{
            //    MessageBox.Show("Reminder time con not be before the start date");
            //    return false;
            //}
            else if (reminderTime > enddate)
            {
                MessageBox.Show("Reminder time con not be after the end date");
                return false;
            }

            bool ovelapping = checkOverlapping(startdate, enddate);

            if (ovelapping == true)
            {
                MessageBox.Show("selected date is overlapping with another date");
                return false;
            }

            return true;

        }

        public bool checkOverlapping(DateTime startDateTime, DateTime endDateTime)
        {
            int is_overlapping;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MainForm.conn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CheckEventOverlap";

            cmd.Parameters.Add("p_userid", MainForm.userId);
            cmd.Parameters.Add("p_StartDateTime", startDateTime);
            cmd.Parameters.Add("p_EndDateTime", endDateTime);
            cmd.Parameters.Add("p_Overlap", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("eventId", editMode ? eventId : 0);

            try
            {
                cmd.ExecuteNonQuery();
                is_overlapping = Convert.ToInt32(cmd.Parameters["p_Overlap"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("ERROR");
                return false;
            }

            Console.WriteLine($"number of overlaps = {is_overlapping}");
            return (is_overlapping > 0);
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
          
        }

        private void AddEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Dispose();
        }
    }
}
