namespace Event_scheduling_planning_system
{
    partial class AddEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            this.eventName_txb = new System.Windows.Forms.TextBox();
            this.end_DT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.saveEvent_btn = new System.Windows.Forms.Button();
            this.reminder_DT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.start_DT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.eventLocation_txb = new System.Windows.Forms.TextBox();
            this.done_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // eventName_txb
            // 
            this.eventName_txb.BackColor = System.Drawing.Color.White;
            this.eventName_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventName_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_txb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eventName_txb.Location = new System.Drawing.Point(18, 9);
            this.eventName_txb.Margin = new System.Windows.Forms.Padding(2);
            this.eventName_txb.Name = "eventName_txb";
            this.eventName_txb.Size = new System.Drawing.Size(190, 23);
            this.eventName_txb.TabIndex = 0;
            this.eventName_txb.Text = "Event Name";
            // 
            // end_DT
            // 
            this.end_DT.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.end_DT.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.end_DT.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.end_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_DT.Location = new System.Drawing.Point(12, 171);
            this.end_DT.Margin = new System.Windows.Forms.Padding(2);
            this.end_DT.Name = "end_DT";
            this.end_DT.Size = new System.Drawing.Size(206, 23);
            this.end_DT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "End Date";
            // 
            // saveEvent_btn
            // 
            this.saveEvent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveEvent_btn.BackgroundImage")));
            this.saveEvent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEvent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEvent_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.saveEvent_btn.FlatAppearance.BorderSize = 0;
            this.saveEvent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEvent_btn.Location = new System.Drawing.Point(116, 289);
            this.saveEvent_btn.Margin = new System.Windows.Forms.Padding(2);
            this.saveEvent_btn.Name = "saveEvent_btn";
            this.saveEvent_btn.Size = new System.Drawing.Size(106, 39);
            this.saveEvent_btn.TabIndex = 25;
            this.saveEvent_btn.UseVisualStyleBackColor = true;
            this.saveEvent_btn.Click += new System.EventHandler(this.saveEvent_btn_Click);
            // 
            // reminder_DT
            // 
            this.reminder_DT.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.reminder_DT.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.reminder_DT.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.reminder_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminder_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reminder_DT.Location = new System.Drawing.Point(12, 241);
            this.reminder_DT.Margin = new System.Windows.Forms.Padding(2);
            this.reminder_DT.Name = "reminder_DT";
            this.reminder_DT.Size = new System.Drawing.Size(206, 23);
            this.reminder_DT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reminder Date";
            // 
            // start_DT
            // 
            this.start_DT.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.start_DT.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.start_DT.CustomFormat = "dd/MM/yyyy  hh:mm tt";
            this.start_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_DT.Location = new System.Drawing.Point(12, 106);
            this.start_DT.Margin = new System.Windows.Forms.Padding(2);
            this.start_DT.Name = "start_DT";
            this.start_DT.Size = new System.Drawing.Size(206, 23);
            this.start_DT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // eventLocation_txb
            // 
            this.eventLocation_txb.BackColor = System.Drawing.Color.White;
            this.eventLocation_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventLocation_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocation_txb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eventLocation_txb.Location = new System.Drawing.Point(18, 43);
            this.eventLocation_txb.Margin = new System.Windows.Forms.Padding(2);
            this.eventLocation_txb.Name = "eventLocation_txb";
            this.eventLocation_txb.Size = new System.Drawing.Size(190, 23);
            this.eventLocation_txb.TabIndex = 2;
            this.eventLocation_txb.Text = "Event Location";
            // 
            // done_checkbox
            // 
            this.done_checkbox.AutoSize = true;
            this.done_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.done_checkbox.Location = new System.Drawing.Point(18, 294);
            this.done_checkbox.Name = "done_checkbox";
            this.done_checkbox.Size = new System.Drawing.Size(60, 19);
            this.done_checkbox.TabIndex = 26;
            this.done_checkbox.Text = "Done";
            this.done_checkbox.UseVisualStyleBackColor = true;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(230, 336);
            this.Controls.Add(this.done_checkbox);
            this.Controls.Add(this.eventName_txb);
            this.Controls.Add(this.eventLocation_txb);
            this.Controls.Add(this.saveEvent_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reminder_DT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_DT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.end_DT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddEventForm";
            this.Text = "Add Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEventForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox eventName_txb;
        private System.Windows.Forms.DateTimePicker end_DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveEvent_btn;
        private System.Windows.Forms.DateTimePicker reminder_DT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_DT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventLocation_txb;
        private System.Windows.Forms.CheckBox done_checkbox;
    }
}