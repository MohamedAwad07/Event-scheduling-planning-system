using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_scheduling_planning_system
{
    public partial class EventCard : UserControl
    {
        public EventCard()
        {
            //Console.WriteLine("Here");
            InitializeComponent();
        }
        public EventCard(string name , string location , string startDate , string endDate , string reminderDate , string status)
        {
            InitializeComponent();
            eventName_lbl.Text = name;
            eventLocation_lbl.Text = location;
            startDate_lbl.Text = startDate;
            endDate_lbl.Text = endDate;
            reminderDate_lbl.Text = reminderDate;
            dayNum_lbl.Text = "";

            string pattern = @"/([^/]*)/";
            MatchCollection matches = Regex.Matches(startDate, pattern);
            if(matches[0].Groups[1].Value.Length < 2 )
            {
                dayNum_lbl.Text = "0";
            }
            dayNum_lbl.Text += matches[0].Groups[1].Value;

            if (status == "Active")
            {

            }
            else
            {

            }
        }

        private void EventCard_Load(object sender, EventArgs e)
        {

        }
    }
}
