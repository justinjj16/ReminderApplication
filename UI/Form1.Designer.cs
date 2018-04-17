namespace ReminderApplication
{
    partial class FrmReminders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblReminderName = new System.Windows.Forms.Label();
            this.txtReminderName = new System.Windows.Forms.TextBox();
            this.lblReminderDescription = new System.Windows.Forms.Label();
            this.rtxtReminderDescription = new System.Windows.Forms.RichTextBox();
            this.dtmReminderDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbReminderPriority = new System.Windows.Forms.ComboBox();
            this.lblReminderBefore = new System.Windows.Forms.Label();
            this.nupReminderMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReminderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupReminderMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReminderName
            // 
            this.lblReminderName.AutoSize = true;
            this.lblReminderName.Location = new System.Drawing.Point(27, 20);
            this.lblReminderName.Name = "lblReminderName";
            this.lblReminderName.Size = new System.Drawing.Size(38, 13);
            this.lblReminderName.TabIndex = 0;
            this.lblReminderName.Text = "NAME";
            // 
            // txtReminderName
            // 
            this.txtReminderName.Location = new System.Drawing.Point(252, 11);
            this.txtReminderName.Name = "txtReminderName";
            this.txtReminderName.Size = new System.Drawing.Size(100, 20);
            this.txtReminderName.TabIndex = 1;
            // 
            // lblReminderDescription
            // 
            this.lblReminderDescription.AutoSize = true;
            this.lblReminderDescription.Location = new System.Drawing.Point(27, 50);
            this.lblReminderDescription.Name = "lblReminderDescription";
            this.lblReminderDescription.Size = new System.Drawing.Size(80, 13);
            this.lblReminderDescription.TabIndex = 2;
            this.lblReminderDescription.Text = "DESCRIPTION";
            // 
            // rtxtReminderDescription
            // 
            this.rtxtReminderDescription.Location = new System.Drawing.Point(252, 37);
            this.rtxtReminderDescription.Name = "rtxtReminderDescription";
            this.rtxtReminderDescription.Size = new System.Drawing.Size(185, 52);
            this.rtxtReminderDescription.TabIndex = 3;
            this.rtxtReminderDescription.Text = "";
            // 
            // dtmReminderDate
            // 
            this.dtmReminderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmReminderDate.Location = new System.Drawing.Point(252, 126);
            this.dtmReminderDate.Name = "dtmReminderDate";
            this.dtmReminderDate.Size = new System.Drawing.Size(99, 20);
            this.dtmReminderDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "DATE";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(27, 171);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(58, 13);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "PRIORITY";
            // 
            // cmbReminderPriority
            // 
            this.cmbReminderPriority.FormattingEnabled = true;
            this.cmbReminderPriority.Location = new System.Drawing.Point(252, 171);
            this.cmbReminderPriority.Name = "cmbReminderPriority";
            this.cmbReminderPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbReminderPriority.TabIndex = 7;
            // 
            // lblReminderBefore
            // 
            this.lblReminderBefore.AutoSize = true;
            this.lblReminderBefore.Location = new System.Drawing.Point(32, 232);
            this.lblReminderBefore.Name = "lblReminderBefore";
            this.lblReminderBefore.Size = new System.Drawing.Size(212, 13);
            this.lblReminderBefore.TabIndex = 8;
            this.lblReminderBefore.Text = "HOW MANY MINUTES BEFORE REMIND";
            // 
            // nupReminderMinutes
            // 
            this.nupReminderMinutes.Location = new System.Drawing.Point(252, 225);
            this.nupReminderMinutes.Name = "nupReminderMinutes";
            this.nupReminderMinutes.Size = new System.Drawing.Size(120, 20);
            this.nupReminderMinutes.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(463, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "CREATE";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReminderName,
            this.Reminder,
            this.ReminderDescription,
            this.ReminderDate,
            this.Priority,
            this.ShowBefore});
            this.dataGridView1.Location = new System.Drawing.Point(4, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 160);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ReminderName
            // 
            this.ReminderName.DataPropertyName = "ReminderName";
            this.ReminderName.HeaderText = "Reminder Name";
            this.ReminderName.Name = "ReminderName";
            this.ReminderName.ReadOnly = true;
            // 
            // Reminder
            // 
            this.Reminder.DataPropertyName = "Reminder";
            this.Reminder.HeaderText = "ReminderId";
            this.Reminder.Name = "Reminder";
            this.Reminder.ReadOnly = true;
            this.Reminder.Visible = false;
            // 
            // ReminderDescription
            // 
            this.ReminderDescription.DataPropertyName = "ReminderDescription";
            this.ReminderDescription.HeaderText = "Reminder Description";
            this.ReminderDescription.Name = "ReminderDescription";
            this.ReminderDescription.ReadOnly = true;
            // 
            // ReminderDate
            // 
            this.ReminderDate.DataPropertyName = "ReminderDate";
            this.ReminderDate.HeaderText = "Reminder Date";
            this.ReminderDate.Name = "ReminderDate";
            this.ReminderDate.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // ShowBefore
            // 
            this.ShowBefore.DataPropertyName = "ShowBefore";
            this.ShowBefore.HeaderText = "Show Before";
            this.ShowBefore.Name = "ShowBefore";
            this.ShowBefore.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(463, 85);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 424);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.nupReminderMinutes);
            this.Controls.Add(this.lblReminderBefore);
            this.Controls.Add(this.cmbReminderPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtmReminderDate);
            this.Controls.Add(this.rtxtReminderDescription);
            this.Controls.Add(this.lblReminderDescription);
            this.Controls.Add(this.txtReminderName);
            this.Controls.Add(this.lblReminderName);
            this.Name = "FrmReminders";
            this.Text = "Reminders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupReminderMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReminderName;
        private System.Windows.Forms.TextBox txtReminderName;
        private System.Windows.Forms.Label lblReminderDescription;
        private System.Windows.Forms.RichTextBox rtxtReminderDescription;
        private System.Windows.Forms.DateTimePicker dtmReminderDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbReminderPriority;
        private System.Windows.Forms.Label lblReminderBefore;
        private System.Windows.Forms.NumericUpDown nupReminderMinutes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowBefore;
        private System.Windows.Forms.Timer timer1;
    }
}

