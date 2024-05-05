using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_scheduling_planning_system
{
    public partial class EditEventForm : Form
    {
        OracleConnection conn;
        int eventId;
        public EditEventForm()
        {
            InitializeComponent();
        }
        public EditEventForm(string name, string location, string startDate, string endDate, string reminderDate, string status, OracleConnection conn, int eventId)
        {
            InitializeComponent();
            eventName_txb.Text = name;
            eventLocation_txb.Text = location;
            start_DT.Text = startDate;
            end_DT.Text = endDate;
            reminder_DT.Text = reminderDate;
            this.conn = conn;
            this.eventId = eventId;
        }

        private void saveEvent_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;


            c.CommandType = CommandType.Text;
            c.CommandText = 
                @"
                    UPDATE EVENTS set
                    EVENTNAME = :name ,
                    EVENTLOCATION = :loc ,
                    STARTDATETIME = :startdate ,
                    ENDDATETIME = :enddate ,
                    REMINDERDATETIME = :reminder,
                    EVENTSTATUS = :status ,
                    WHERE EVENTID = :id;
                ";

         

            c.Parameters.Add("name", eventName_txb.Text.ToString());
            c.Parameters.Add("eventLocation", eventLocation_txb.Text.ToString());
            c.Parameters.Add("startdate", start_DT.Value);
            c.Parameters.Add("enddate", end_DT.Value);
            c.Parameters.Add("reminder", reminder_DT.Value);
            c.Parameters.Add("status", "Inactive");

            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Event updated successfully");
                this.Close();
            }
            else
                MessageBox.Show("Something went worng");
        }
    }
}
