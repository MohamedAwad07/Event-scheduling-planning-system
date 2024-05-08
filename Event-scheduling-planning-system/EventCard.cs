using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_scheduling_planning_system
{
    public partial class EventCard : UserControl
    {
   
        string name;
        string location;
        string startDate;
        string endDate;
        string reminderDate;
        string status;
        int eventId;

        FlowLayoutPanel homePageBody;
        public EventCard()
        {
            InitializeComponent();
        }
        public EventCard(string name , string location , string startDate , string endDate , string reminderDate , string status, int eventId , FlowLayoutPanel homePageBody)
        {
            InitializeComponent();
            eventName_lbl.Text = name;
            eventLocation_lbl.Text = location;
            startDate_lbl.Text = startDate;
            endDate_lbl.Text = endDate;
            reminderDate_lbl.Text = reminderDate;
            dayNum_lbl.Text = "";


            this.homePageBody = homePageBody; 
            this.name = name;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reminderDate = reminderDate;
            this.status = status;
            this.eventId = eventId;
            if(status == "done")
            {
                done_pic.Visible = true;
            }

            //Console.WriteLine("Id" + eventId);
            string pattern = @"/([^/]*)/";
            MatchCollection matches = Regex.Matches(startDate, pattern);
            if(matches[0].Groups[1].Value.Length < 2)  dayNum_lbl.Text = "0";
           
            dayNum_lbl.Text += matches[0].Groups[1].Value;

        }

        private void deleteEvent_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandType = CommandType.Text;
            c.CommandText = "DELETE FROM EVENTS WHERE EVENTID = :id";
            c.Parameters.Add("Id", eventId);

            int r = c.ExecuteNonQuery();

            if (r != -1) 
            {
                MessageBox.Show("Deleted successfully");
                Stack_Event events = new Stack_Event
                (
                Stack_Event.Actions.DELETE,
                eventId,
                name,
                location,
                Convert.ToDateTime(startDate),
                Convert.ToDateTime(endDate),
                Convert.ToDateTime(reminderDate),
                status
                );
                Stack_handling.saveAction(events);
                Stack_handling.redo_stack.Clear();
                this.Dispose();
            }
            else
                MessageBox.Show("Something went wrong");

        }

        private void editEvent_btn_Click(object sender, EventArgs e)
        { 
           (new AddEventForm(name, location, startDate, endDate, reminderDate, status, eventId , homePageBody)).ShowDialog();
        }
    }
}
