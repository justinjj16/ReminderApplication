using ReminderApplication.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApplication.BL
{
    public class ReminderBL
    {
        public int ReminderId { get; set; }

        public string ReminderName { get; set; }

            public string ReminderDescription { get; set; }
            public DateTime ReminderDate { get; set; }
            public int ShowBefore { get; set; }

            public int ReminderPriority  { get; set; }

           

            internal void SaveReminders()
            {
                ReminderDL reminderdlobject = new ReminderDL();
                reminderdlobject.SaveReminders(this);

            }


            internal DataTable LoadReminders()
            {
                ReminderDL reminderdlobject = new ReminderDL();
                 return reminderdlobject.LoadReminders();
            }

            internal void UpdateReminders()
            {
                ReminderDL reminderdlobject = new ReminderDL();
                reminderdlobject.UpdateReminders(this);
            }

            internal DataTable GetReminderOnTime()
            {
                ReminderDL reminderdlobject = new ReminderDL();
                return  reminderdlobject.GetReminderOnTime();
            }
    }
}
