using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_scheduling_planning_system
{
    internal class Stack_handling
    {


        public static Stack<Stack_Event> redo_stack = new Stack<Stack_Event>();
        public static Stack<Stack_Event> undo_stack = new Stack<Stack_Event>();


        public static void undo()
        {
            //Console.WriteLine("undo called");
            if (undo_stack.Count <= 0) return;
            Stack_Event currEvent = undo_stack.Pop();
           

            // Console.WriteLine("user id from undo " + currEvent.userId);
            if (currEvent.action == Stack_Event.Actions.ADD)
            {
                if(deleteEvent(currEvent))
                    redo_stack.Push(currEvent);
            }
            else if (currEvent.action == Stack_Event.Actions.DELETE)
            {
                if(addEvent(currEvent))
                    redo_stack.Push(currEvent);
            }
            else
            {
                if(editEvent(currEvent))
                    redo_stack.Push(currEvent);
            }
        }
        public static void redo()
        {
            //Console.WriteLine("redo called");
            if (redo_stack.Count <= 0) return;
            Stack_Event currEvent = redo_stack.Pop();
         
            //Console.WriteLine("user id from redo " + currEvent.userId);
            if (currEvent.action == Stack_Event.Actions.ADD)
            {
                if(addEvent(currEvent)) undo_stack.Push(currEvent);

            }
            else if (currEvent.action == Stack_Event.Actions.DELETE)
            {
                if(deleteEvent(currEvent))
                    undo_stack.Push(currEvent);
            }
            else 
            {
                if(editEvent(currEvent))
                    undo_stack.Push(currEvent);
            }
        }

        public static void saveAction(Stack_Event eventToSave)
        {
            undo_stack.Push(eventToSave);
        }

        private static bool deleteEvent(Stack_Event currEvent)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandType = CommandType.Text;
            c.CommandText = "DELETE FROM EVENTS WHERE EVENTID = :id";
            c.Parameters.Add("Id", currEvent.eventId);

            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
                return true;
            }
            else
                MessageBox.Show("Something went wrong");
            return false;
        }

        private static bool addEvent(Stack_Event currEvent)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;


            c.CommandText = "Insert into EVENTS values (:Id , :name , :startdate , :enddate , :reminderDate , :eventLocation , :status , :userId)";
            c.CommandType = CommandType.Text;

            c.Parameters.Add("Id", currEvent.eventId);
            c.Parameters.Add("name", currEvent.eventName);
            c.Parameters.Add("startdate", currEvent.eventStartDate);
            c.Parameters.Add("enddate", currEvent.eventEndDate);
            c.Parameters.Add("reminderDate", currEvent.eventReminderDate);
            c.Parameters.Add("eventLocation", currEvent.eventLoc);
            c.Parameters.Add("status", currEvent.eventStatus);
            c.Parameters.Add("userId", MainForm.userId);

            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
                return true;
            }
            else
                MessageBox.Show("Something went wrong");
            return false;
        }

        private static bool editEvent(Stack_Event currentEvent)
        {
            Stack_Event dbEvent = getOldData(currentEvent.eventId);
        
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

            c.Parameters.Add("name", currentEvent.eventName);
            c.Parameters.Add("loc", currentEvent.eventLoc);
            c.Parameters.Add("startdate", currentEvent.eventStartDate);
            c.Parameters.Add("enddate", currentEvent.eventEndDate);
            c.Parameters.Add("reminder", currentEvent.eventReminderDate);
            c.Parameters.Add("status", currentEvent.eventStatus);
            c.Parameters.Add("id", currentEvent.eventId);


            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
                currentEvent = dbEvent;
                Console.WriteLine("Name old " + currentEvent.eventName);
                Console.WriteLine("Name db " + dbEvent.eventName);
                return true;
            }
            else
                MessageBox.Show("Something went wrong");
            return false;
        }

        public static Stack_Event getOldData(int eventId)
        {
            Stack_Event oldEvent = new Stack_Event(eventId , Stack_Event.Actions.EDIT);
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandType = CommandType.Text;
            Console.WriteLine("IDDDDDDDDDDDDDDDD " + eventId);
            c.CommandText = "SELECT * FROM EVENTS WHERE EVENTID = :id";

            c.Parameters.Add("id", eventId);

            OracleDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Name "  + dr["EVENTNAME"].ToString());
                oldEvent.eventName = dr["EVENTNAME"].ToString();
                oldEvent.eventLoc = dr["EVENTLOCATION"].ToString();
                oldEvent.eventStartDate = Convert.ToDateTime(dr["STARTDATETIME"].ToString());
                oldEvent.eventEndDate = Convert.ToDateTime(dr["ENDDATETIME"].ToString());
                oldEvent.eventReminderDate = Convert.ToDateTime(dr["REMINDERDATETIME"].ToString());
                oldEvent.eventStatus = dr["EVENTSTATUS"].ToString();
            }
            dr.Close();

            return oldEvent;
        }
    }

}