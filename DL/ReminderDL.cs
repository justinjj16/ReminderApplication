using ReminderApplication.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApplication.DL
{
    public class ReminderDL
    {
        internal void SaveReminders(ReminderBL reminderBL)
        {
            try
            {
                using (SqlConnection openCon = new SqlConnection("Data Source=justin\\sqlexpress;Initial Catalog=Reminders;Integrated Security=True;"))
                {


                    using (SqlCommand remindercmd = new SqlCommand())
                    {
                        remindercmd.Connection = openCon;

                        remindercmd.Parameters.Add("@ReminderName", SqlDbType.VarChar, 50).Value = reminderBL.ReminderName;
                        remindercmd.Parameters.Add("@ReminderDescription", SqlDbType.VarChar, 1000).Value = reminderBL.ReminderDescription;
                        remindercmd.Parameters.Add("@ReminderDate", SqlDbType.DateTime, 30).Value = reminderBL.ReminderDate;
                        remindercmd.Parameters.Add("@ShowBefore", SqlDbType.Int, 30).Value = reminderBL.ShowBefore;
                        remindercmd.Parameters.Add("@ReminderPriority", SqlDbType.Int, 30).Value = reminderBL.ReminderPriority;


                        remindercmd.CommandType = CommandType.StoredProcedure;
                        remindercmd.CommandText = "dbo.SaveReminders";
                        openCon.Open();

                        remindercmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        internal DataTable LoadReminders()
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=justin\\sqlexpress;Initial Catalog=Reminders;Integrated Security=True;"))
            {
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = openCon;

                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "dbo.[SelectAllReminders]";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);

                    return dtRecord;
                }
            }
        }

        internal void UpdateReminders(ReminderBL reminderBL)
        {
            try
            {
                using (SqlConnection openCon = new SqlConnection("Data Source=justin\\sqlexpress;Initial Catalog=Reminders;Integrated Security=True;"))
                {


                    using (SqlCommand remindercmd = new SqlCommand())
                    {
                        remindercmd.Connection = openCon;
                        remindercmd.Parameters.Add("@ReminderId", SqlDbType.Int, 50).Value = reminderBL.ReminderId;
                        remindercmd.Parameters.Add("@ReminderName", SqlDbType.VarChar, 50).Value = reminderBL.ReminderName;
                        remindercmd.Parameters.Add("@ReminderDescription", SqlDbType.VarChar, 1000).Value = reminderBL.ReminderDescription;
                        remindercmd.Parameters.Add("@ReminderDate", SqlDbType.DateTime, 30).Value = reminderBL.ReminderDate;
                        remindercmd.Parameters.Add("@ShowBefore", SqlDbType.Int, 30).Value = reminderBL.ShowBefore;
                        remindercmd.Parameters.Add("@ReminderPriority", SqlDbType.Int, 30).Value = reminderBL.ReminderPriority;


                        remindercmd.CommandType = CommandType.StoredProcedure;
                        remindercmd.CommandText = "dbo.UpdateReminder";
                        openCon.Open();

                        remindercmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        internal DataTable GetReminderOnTime()
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=justin\\sqlexpress;Initial Catalog=Reminders;Integrated Security=True;"))
            {
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = openCon;

                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "dbo.[SelectAllRemindersOnTime]";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                    sqlCmd.Parameters.Add("@CurrentDateTime", SqlDbType.DateTime, 30).Value = DateTime.Now;

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);

                    return dtRecord;
                }
            }

        }
    }
}
