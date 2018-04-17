namespace ReminderApplication.UI
{
   public partial class ShowReminders
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblReminderName = new System.Windows.Forms.Label();
            this.lblReminderDescription = new System.Windows.Forms.Label();
            this.lblReminderDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REMINDER";
            // 
            // lblReminderName
            // 
            this.lblReminderName.AutoSize = true;
            this.lblReminderName.Location = new System.Drawing.Point(119, 115);
            this.lblReminderName.Name = "lblReminderName";
            this.lblReminderName.Size = new System.Drawing.Size(38, 13);
            this.lblReminderName.TabIndex = 1;
            this.lblReminderName.Text = "NAME";
            // 
            // lblReminderDescription
            // 
            this.lblReminderDescription.AutoSize = true;
            this.lblReminderDescription.Location = new System.Drawing.Point(119, 162);
            this.lblReminderDescription.Name = "lblReminderDescription";
            this.lblReminderDescription.Size = new System.Drawing.Size(80, 13);
            this.lblReminderDescription.TabIndex = 2;
            this.lblReminderDescription.Text = "DESCRIPTION";
            // 
            // lblReminderDate
            // 
            this.lblReminderDate.AutoSize = true;
            this.lblReminderDate.Location = new System.Drawing.Point(119, 217);
            this.lblReminderDate.Name = "lblReminderDate";
            this.lblReminderDate.Size = new System.Drawing.Size(36, 13);
            this.lblReminderDate.TabIndex = 3;
            this.lblReminderDate.Text = "DATE";
            // 
            // ShowReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 320);
            this.Controls.Add(this.lblReminderDate);
            this.Controls.Add(this.lblReminderDescription);
            this.Controls.Add(this.lblReminderName);
            this.Controls.Add(this.label1);
            this.Name = "ShowReminders";
            this.Text = "ShowReminders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReminderName;
        private System.Windows.Forms.Label lblReminderDescription;
        private System.Windows.Forms.Label lblReminderDate;
    }
}