﻿namespace Event_scheduling_planning_system
{
    partial class EventCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCard));
            this.dayNum_pic = new System.Windows.Forms.PictureBox();
            this.dayNum_lbl = new System.Windows.Forms.Label();
            this.editEvent_btn = new System.Windows.Forms.Button();
            this.deleteEvent_btn = new System.Windows.Forms.Button();
            this.eventName_lbl = new System.Windows.Forms.Label();
            this.eventLocation_lbl = new System.Windows.Forms.Label();
            this.start_DT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dayNum_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // dayNum_pic
            // 
            this.dayNum_pic.Image = ((System.Drawing.Image)(resources.GetObject("dayNum_pic.Image")));
            this.dayNum_pic.Location = new System.Drawing.Point(22, 34);
            this.dayNum_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayNum_pic.Name = "dayNum_pic";
            this.dayNum_pic.Size = new System.Drawing.Size(123, 146);
            this.dayNum_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dayNum_pic.TabIndex = 0;
            this.dayNum_pic.TabStop = false;
            // 
            // dayNum_lbl
            // 
            this.dayNum_lbl.AutoSize = true;
            this.dayNum_lbl.BackColor = System.Drawing.Color.White;
            this.dayNum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNum_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.dayNum_lbl.Location = new System.Drawing.Point(44, 98);
            this.dayNum_lbl.Name = "dayNum_lbl";
            this.dayNum_lbl.Size = new System.Drawing.Size(80, 55);
            this.dayNum_lbl.TabIndex = 1;
            this.dayNum_lbl.Text = "10";
            this.dayNum_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editEvent_btn
            // 
            this.editEvent_btn.BackColor = System.Drawing.Color.DarkGray;
            this.editEvent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editEvent_btn.BackgroundImage")));
            this.editEvent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEvent_btn.FlatAppearance.BorderSize = 0;
            this.editEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(192)))), ((int)(((byte)(49)))));
            this.editEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEvent_btn.Location = new System.Drawing.Point(844, 170);
            this.editEvent_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editEvent_btn.Name = "editEvent_btn";
            this.editEvent_btn.Size = new System.Drawing.Size(39, 39);
            this.editEvent_btn.TabIndex = 5;
            this.editEvent_btn.UseVisualStyleBackColor = false;
            // 
            // deleteEvent_btn
            // 
            this.deleteEvent_btn.BackColor = System.Drawing.Color.DarkGray;
            this.deleteEvent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteEvent_btn.BackgroundImage")));
            this.deleteEvent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteEvent_btn.FlatAppearance.BorderSize = 0;
            this.deleteEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEvent_btn.Location = new System.Drawing.Point(792, 170);
            this.deleteEvent_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEvent_btn.Name = "deleteEvent_btn";
            this.deleteEvent_btn.Size = new System.Drawing.Size(39, 39);
            this.deleteEvent_btn.TabIndex = 6;
            this.deleteEvent_btn.UseVisualStyleBackColor = false;
            // 
            // eventName_lbl
            // 
            this.eventName_lbl.AutoSize = true;
            this.eventName_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.eventName_lbl.Location = new System.Drawing.Point(165, 18);
            this.eventName_lbl.Name = "eventName_lbl";
            this.eventName_lbl.Size = new System.Drawing.Size(100, 34);
            this.eventName_lbl.TabIndex = 2;
            this.eventName_lbl.Text = "Name:";
            // 
            // eventLocation_lbl
            // 
            this.eventLocation_lbl.AutoSize = true;
            this.eventLocation_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocation_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.eventLocation_lbl.Location = new System.Drawing.Point(165, 72);
            this.eventLocation_lbl.Name = "eventLocation_lbl";
            this.eventLocation_lbl.Size = new System.Drawing.Size(134, 34);
            this.eventLocation_lbl.TabIndex = 2;
            this.eventLocation_lbl.Text = "Location:";
            // 
            // start_DT
            // 
            this.start_DT.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.start_DT.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.start_DT.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.start_DT.CustomFormat = "dd/MM/yyyy  hh:mm ##";
            this.start_DT.Enabled = false;
            this.start_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_DT.Location = new System.Drawing.Point(171, 127);
            this.start_DT.Name = "start_DT";
            this.start_DT.Size = new System.Drawing.Size(276, 35);
            this.start_DT.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy  hh:mm ##";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 35);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(450, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(271, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "event name";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(305, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "event location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(165, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reminder Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy  hh:mm ##";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(390, 176);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(276, 35);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // EventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.start_DT);
            this.Controls.Add(this.dayNum_lbl);
            this.Controls.Add(this.dayNum_pic);
            this.Controls.Add(this.editEvent_btn);
            this.Controls.Add(this.deleteEvent_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventLocation_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventName_lbl);
            this.Margin = new System.Windows.Forms.Padding(30, 20, 0, 10);
            this.Name = "EventCard";
            this.Size = new System.Drawing.Size(900, 230);
            ((System.ComponentModel.ISupportInitialize)(this.dayNum_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dayNum_pic;
        public System.Windows.Forms.Label dayNum_lbl;
        public System.Windows.Forms.Button editEvent_btn;
        public System.Windows.Forms.Button deleteEvent_btn;
        public System.Windows.Forms.Label eventName_lbl;
        public System.Windows.Forms.Label eventLocation_lbl;
        private System.Windows.Forms.DateTimePicker start_DT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
