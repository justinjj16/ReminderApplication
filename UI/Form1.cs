using ReminderApplication.BL;
using ReminderApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderApplication
{
    public partial class FrmReminders : Form
    {
        public FrmReminders()
        {
            InitializeComponent();
        }

        int ReminderId = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            ReminderBL reminderobj = new ReminderBL();
            dataGridView1.DataSource= reminderobj.LoadReminders();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ReminderBL reminderobj = new ReminderBL();

            reminderobj.ReminderName = txtReminderName.Text;
            reminderobj.ReminderDescription = rtxtReminderDescription.Text;
            reminderobj.ReminderDate = dtmReminderDate.Value;
            reminderobj.ReminderPriority = 1;
            reminderobj.ShowBefore =Convert.ToInt32(nupReminderMinutes.Value);

            reminderobj.SaveReminders();
            dataGridView1.DataSource = reminderobj.LoadReminders();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReminderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Reminder"].Value);
            txtReminderName.Text = dataGridView1.Rows[e.RowIndex].Cells["ReminderName"].Value.ToString();
            rtxtReminderDescription.Text = dataGridView1.Rows[e.RowIndex].Cells["ReminderDescription"].Value.ToString();
            dtmReminderDate.Text = dataGridView1.Rows[e.RowIndex].Cells["ReminderDate"].Value.ToString();
            nupReminderMinutes.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ShowBefore"].Value);





        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ReminderId > 0)
            {
                ReminderBL reminderobj = new ReminderBL();
                reminderobj.ReminderId = ReminderId;


                reminderobj.ReminderName = txtReminderName.Text;
                reminderobj.ReminderDescription = rtxtReminderDescription.Text;
                reminderobj.ReminderDate = dtmReminderDate.Value;
                reminderobj.ReminderPriority = 1;
                reminderobj.ShowBefore = Convert.ToInt32(nupReminderMinutes.Value);

                reminderobj.UpdateReminders();
                dataGridView1.DataSource = reminderobj.LoadReminders();
                
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            ReminderBL reminderobj = new ReminderBL();
            
            DataTable dt=  reminderobj.GetReminderOnTime();

            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string remindername = Convert.ToString(dt.Rows[i]["ReminderName"]);
                    string reminderdesc = Convert.ToString(dt.Rows[i]["ReminderDescription"]);
                    string reminderdate = Convert.ToString(dt.Rows[i]["ReminderDate"]);

                ShowReminders showreminderPopUp = new ShowReminders(remindername, reminderdesc, reminderdate);

                showreminderPopUp.Show();
            }


            timer1.Start();
        }
    }
}
