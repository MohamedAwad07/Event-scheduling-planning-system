using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Event_scheduling_planning_system
{
    internal class Admin
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder command;
        DataSet ds;

        DateTimePicker startDate,  endDate;
        public Admin(DataGridView dataGrid , DateTimePicker startDate , DateTimePicker endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            string cmdstr = @"SELECT * FROM EVENTS 
                              WHERE 
                              STARTDATETIME <= :startDate AND
                              ENDDATETIME >= :endDate
                                ";



            adapter = new OracleDataAdapter(cmdstr, MainForm.ordb);
            adapter.SelectCommand.Parameters.Add("startDate", startDate.Text);
            adapter.SelectCommand.Parameters.Add("endDate", endDate.Text);

            ds = new DataSet();

            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0];
        }
        
    }
}
