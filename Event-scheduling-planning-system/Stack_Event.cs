using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_scheduling_planning_system
{
    
    internal class Stack_Event
    {
        public enum Actions
        {
            ADD ,
            DELETE , 
            EDIT,
        }

        public Actions action;
         
        public int eventId;
        public string eventName;
        public string eventLoc;
        public DateTime eventStartDate;
        public DateTime eventEndDate;
        public DateTime eventReminderDate;
        public string eventStatus;


        public Stack_Event(Actions action, int eventId, string eventName, string eventLoc, DateTime eventStartDate, DateTime eventEndDate, DateTime eventReminderDate, string eventStatus)
        {
            this.action = action;
            this.eventId = eventId;
            this.eventName = eventName;
            this.eventLoc = eventLoc;
            this.eventStartDate = eventStartDate;
            this.eventEndDate = eventEndDate;
            this.eventReminderDate = eventReminderDate;
            this.eventStatus = eventStatus;
        }
        public Stack_Event(int id , Actions action)
        {
            this.eventId = id;
            this.action = action;
        }
    }
}
