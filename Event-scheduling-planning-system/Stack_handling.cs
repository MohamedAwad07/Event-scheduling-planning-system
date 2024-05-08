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
            Console.WriteLine("undo called");
            if (undo_stack.Count <= 0) return;
            Stack_Event currEvent = undo_stack.Pop();
            redo_stack.Push(currEvent);

            Console.WriteLine("user id from undo " + currEvent.userId);
            if (currEvent.action == Stack_Event.Actions.ADD)
            {
                deleteEvent(currEvent);
            }
            else if (currEvent.action == Stack_Event.Actions.DELETE)
            {
                addEvent(currEvent);
            }
            else
            {

            }
        }
        public static void redo()
        {
            Console.WriteLine("redo called");
            if (redo_stack.Count <= 0) return;
            Stack_Event currEvent = redo_stack.Pop();
            undo_stack.Push(currEvent);


            Console.WriteLine("user id from redo " + currEvent.userId);
            if (currEvent.action == Stack_Event.Actions.ADD)
            {
                addEvent(currEvent);
            }
            else if (currEvent.action == Stack_Event.Actions.DELETE)
            {
                deleteEvent(currEvent);
            }
            else
            {

            }
        }

        public static void saveAction(Stack_Event eventToSave)
        {
            undo_stack.Push(eventToSave);
        }

        private static void deleteEvent(Stack_Event currEvent)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = MainForm.conn;

            c.CommandType = CommandType.Text;
            c.CommandText = "DELETE FROM EVENTS WHERE EVENTID = :id";
            c.Parameters.Add("Id", currEvent.eventId);

            int r = c.ExecuteNonQuery();

            if (r != -1)
            {

            }
            else
                MessageBox.Show("Something went wrong");
        }

        private static void addEvent(Stack_Event currEvent)
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
            c.Parameters.Add("userId", currEvent.userId);

            int r = c.ExecuteNonQuery();

            if (r != -1)
            {

            }
            else
                MessageBox.Show("Something went wrong");
        }
    }
}
