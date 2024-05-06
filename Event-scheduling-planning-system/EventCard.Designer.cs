namespace Event_scheduling_planning_system
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate_lbl = new System.Windows.Forms.Label();
            this.endDate_lbl = new System.Windows.Forms.Label();
            this.reminderDate_lbl = new System.Windows.Forms.Label();
            this.eventLocation_lbl = new System.Windows.Forms.Label();
            this.done_pic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayNum_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // dayNum_pic
            // 
            this.dayNum_pic.Image = ((System.Drawing.Image)(resources.GetObject("dayNum_pic.Image")));
            this.dayNum_pic.Location = new System.Drawing.Point(15, 16);
            this.dayNum_pic.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dayNum_pic.Name = "dayNum_pic";
            this.dayNum_pic.Size = new System.Drawing.Size(82, 95);
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
            this.dayNum_lbl.Location = new System.Drawing.Point(29, 58);
            this.dayNum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayNum_lbl.Name = "dayNum_lbl";
            this.dayNum_lbl.Size = new System.Drawing.Size(53, 37);
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
            this.editEvent_btn.Location = new System.Drawing.Point(565, 97);
            this.editEvent_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editEvent_btn.Name = "editEvent_btn";
            this.editEvent_btn.Size = new System.Drawing.Size(26, 25);
            this.editEvent_btn.TabIndex = 5;
            this.editEvent_btn.UseVisualStyleBackColor = false;
            this.editEvent_btn.Click += new System.EventHandler(this.editEvent_btn_Click);
            // 
            // deleteEvent_btn
            // 
            this.deleteEvent_btn.BackColor = System.Drawing.Color.DarkGray;
            this.deleteEvent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteEvent_btn.BackgroundImage")));
            this.deleteEvent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteEvent_btn.FlatAppearance.BorderSize = 0;
            this.deleteEvent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteEvent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEvent_btn.Location = new System.Drawing.Point(530, 97);
            this.deleteEvent_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.deleteEvent_btn.Name = "deleteEvent_btn";
            this.deleteEvent_btn.Size = new System.Drawing.Size(26, 25);
            this.deleteEvent_btn.TabIndex = 6;
            this.deleteEvent_btn.UseVisualStyleBackColor = false;
            this.deleteEvent_btn.Click += new System.EventHandler(this.deleteEvent_btn_Click);
            // 
            // eventName_lbl
            // 
            this.eventName_lbl.AutoSize = true;
            this.eventName_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.eventName_lbl.Location = new System.Drawing.Point(275, 11);
            this.eventName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventName_lbl.Name = "eventName_lbl";
            this.eventName_lbl.Size = new System.Drawing.Size(119, 25);
            this.eventName_lbl.TabIndex = 2;
            this.eventName_lbl.Text = "Event Name";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.lable1.Location = new System.Drawing.Point(110, 47);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(73, 19);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(308, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(110, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reminder:";
            // 
            // startDate_lbl
            // 
            this.startDate_lbl.AutoSize = true;
            this.startDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_lbl.Location = new System.Drawing.Point(159, 74);
            this.startDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDate_lbl.Name = "startDate_lbl";
            this.startDate_lbl.Size = new System.Drawing.Size(148, 17);
            this.startDate_lbl.TabIndex = 7;
            this.startDate_lbl.Text = "04/05/2024  05:43 PM";
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.AutoSize = true;
            this.endDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_lbl.Location = new System.Drawing.Point(334, 73);
            this.endDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.Size = new System.Drawing.Size(148, 17);
            this.endDate_lbl.TabIndex = 7;
            this.endDate_lbl.Text = "04/05/2024  05:43 PM";
            // 
            // reminderDate_lbl
            // 
            this.reminderDate_lbl.AutoSize = true;
            this.reminderDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderDate_lbl.Location = new System.Drawing.Point(191, 101);
            this.reminderDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reminderDate_lbl.Name = "reminderDate_lbl";
            this.reminderDate_lbl.Size = new System.Drawing.Size(148, 17);
            this.reminderDate_lbl.TabIndex = 7;
            this.reminderDate_lbl.Text = "04/05/2024  05:43 PM";
            // 
            // eventLocation_lbl
            // 
            this.eventLocation_lbl.AutoSize = true;
            this.eventLocation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocation_lbl.Location = new System.Drawing.Point(183, 48);
            this.eventLocation_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventLocation_lbl.Name = "eventLocation_lbl";
            this.eventLocation_lbl.Size = new System.Drawing.Size(116, 17);
            this.eventLocation_lbl.TabIndex = 7;
            this.eventLocation_lbl.Text = "South Ain Shams";
            // 
            // done_pic
            // 
            this.done_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("done_pic.BackgroundImage")));
            this.done_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.done_pic.Location = new System.Drawing.Point(521, -10);
            this.done_pic.Name = "done_pic";
            this.done_pic.Size = new System.Drawing.Size(90, 90);
            this.done_pic.TabIndex = 8;
            this.done_pic.TabStop = false;
            this.done_pic.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(110, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // EventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.done_pic);
            this.Controls.Add(this.reminderDate_lbl);
            this.Controls.Add(this.endDate_lbl);
            this.Controls.Add(this.eventLocation_lbl);
            this.Controls.Add(this.startDate_lbl);
            this.Controls.Add(this.dayNum_lbl);
            this.Controls.Add(this.dayNum_pic);
            this.Controls.Add(this.editEvent_btn);
            this.Controls.Add(this.deleteEvent_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventName_lbl);
            this.Margin = new System.Windows.Forms.Padding(20, 13, 0, 6);
            this.Name = "EventCard";
            this.Size = new System.Drawing.Size(600, 130);
            ((System.ComponentModel.ISupportInitialize)(this.dayNum_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dayNum_pic;
        public System.Windows.Forms.Label dayNum_lbl;
        public System.Windows.Forms.Button editEvent_btn;
        public System.Windows.Forms.Button deleteEvent_btn;
        public System.Windows.Forms.Label eventName_lbl;
        public System.Windows.Forms.Label lable1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startDate_lbl;
        private System.Windows.Forms.Label endDate_lbl;
        private System.Windows.Forms.Label reminderDate_lbl;
        private System.Windows.Forms.Label eventLocation_lbl;
        private System.Windows.Forms.PictureBox done_pic;
        public System.Windows.Forms.Label label3;
    }
}
