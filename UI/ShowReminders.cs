using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderApplication.UI
{
    public partial class ShowReminders : Form
    {
        public ShowReminders(string remindername,string reminderdescription,string reminderdate)
        {
            InitializeComponent();

            lblReminderName.Text = remindername;

            lblReminderDescription.Text = reminderdescription;

            lblReminderDate.Text = reminderdate;
        }
    }
}
