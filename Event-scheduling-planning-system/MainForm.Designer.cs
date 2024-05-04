namespace Event_scheduling_planning_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Login_page = new System.Windows.Forms.Panel();
            this.eye_open1 = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Label();
            this.password1_txb = new System.Windows.Forms.TextBox();
            this.username1_txb = new System.Windows.Forms.TextBox();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.Signup_page = new System.Windows.Forms.Panel();
            this.eye_open3 = new System.Windows.Forms.Button();
            this.eye_close3 = new System.Windows.Forms.Button();
            this.eye_open2 = new System.Windows.Forms.Button();
            this.eye_close2 = new System.Windows.Forms.Button();
            this.confirm_pass_txb = new System.Windows.Forms.TextBox();
            this.email_txb = new System.Windows.Forms.TextBox();
            this.username2_txb = new System.Windows.Forms.TextBox();
            this.password2_txb = new System.Windows.Forms.TextBox();
            this.signIn_btn = new System.Windows.Forms.Label();
            this.create_acc_btn = new System.Windows.Forms.Button();
            this.eye_close1 = new System.Windows.Forms.Button();
            this.Login_page.SuspendLayout();
            this.Signup_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_page
            // 
            this.Login_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_page.BackgroundImage")));
            this.Login_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_page.Controls.Add(this.eye_open1);
            this.Login_page.Controls.Add(this.eye_close1);
            this.Login_page.Controls.Add(this.signUp_btn);
            this.Login_page.Controls.Add(this.password1_txb);
            this.Login_page.Controls.Add(this.username1_txb);
            this.Login_page.Controls.Add(this.logIn_btn);
            this.Login_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_page.Location = new System.Drawing.Point(0, 0);
            this.Login_page.Name = "Login_page";
            this.Login_page.Size = new System.Drawing.Size(978, 744);
            this.Login_page.TabIndex = 33;
            // 
            // eye_open1
            // 
            this.eye_open1.BackColor = System.Drawing.Color.Transparent;
            this.eye_open1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_open1.BackgroundImage")));
            this.eye_open1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_open1.CausesValidation = false;
            this.eye_open1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_open1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_open1.FlatAppearance.BorderSize = 0;
            this.eye_open1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_open1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_open1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_open1.Location = new System.Drawing.Point(654, 401);
            this.eye_open1.Name = "eye_open1";
            this.eye_open1.Size = new System.Drawing.Size(35, 35);
            this.eye_open1.TabIndex = 4;
            this.eye_open1.UseVisualStyleBackColor = false;
            // 
            // signUp_btn
            // 
            this.signUp_btn.AutoSize = true;
            this.signUp_btn.BackColor = System.Drawing.Color.Transparent;
            this.signUp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.signUp_btn.Location = new System.Drawing.Point(538, 569);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(86, 26);
            this.signUp_btn.TabIndex = 3;
            this.signUp_btn.Text = "Signup";
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // password1_txb
            // 
            this.password1_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.password1_txb.Location = new System.Drawing.Point(288, 404);
            this.password1_txb.Name = "password1_txb";
            this.password1_txb.Size = new System.Drawing.Size(366, 32);
            this.password1_txb.TabIndex = 2;
            this.password1_txb.Text = "Password";
            // 
            // username1_txb
            // 
            this.username1_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username1_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username1_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.username1_txb.Location = new System.Drawing.Point(288, 305);
            this.username1_txb.Name = "username1_txb";
            this.username1_txb.Size = new System.Drawing.Size(401, 32);
            this.username1_txb.TabIndex = 1;
            this.username1_txb.Text = "Username";
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.Color.Transparent;
            this.logIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.logIn_btn.FlatAppearance.BorderSize = 0;
            this.logIn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logIn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn_btn.Location = new System.Drawing.Point(352, 490);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(278, 57);
            this.logIn_btn.TabIndex = 0;
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // Signup_page
            // 
            this.Signup_page.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Signup_page.BackgroundImage")));
            this.Signup_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signup_page.Controls.Add(this.eye_open3);
            this.Signup_page.Controls.Add(this.eye_close3);
            this.Signup_page.Controls.Add(this.eye_open2);
            this.Signup_page.Controls.Add(this.eye_close2);
            this.Signup_page.Controls.Add(this.confirm_pass_txb);
            this.Signup_page.Controls.Add(this.email_txb);
            this.Signup_page.Controls.Add(this.username2_txb);
            this.Signup_page.Controls.Add(this.password2_txb);
            this.Signup_page.Controls.Add(this.signIn_btn);
            this.Signup_page.Controls.Add(this.create_acc_btn);
            this.Signup_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signup_page.Location = new System.Drawing.Point(0, 0);
            this.Signup_page.Name = "Signup_page";
            this.Signup_page.Size = new System.Drawing.Size(978, 744);
            this.Signup_page.TabIndex = 34;
            // 
            // eye_open3
            // 
            this.eye_open3.BackColor = System.Drawing.Color.Transparent;
            this.eye_open3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_open3.BackgroundImage")));
            this.eye_open3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_open3.CausesValidation = false;
            this.eye_open3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_open3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_open3.FlatAppearance.BorderSize = 0;
            this.eye_open3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_open3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_open3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_open3.Location = new System.Drawing.Point(636, 474);
            this.eye_open3.Name = "eye_open3";
            this.eye_open3.Size = new System.Drawing.Size(35, 35);
            this.eye_open3.TabIndex = 9;
            this.eye_open3.UseVisualStyleBackColor = false;
            // 
            // eye_close3
            // 
            this.eye_close3.BackColor = System.Drawing.Color.Transparent;
            this.eye_close3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_close3.BackgroundImage")));
            this.eye_close3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_close3.CausesValidation = false;
            this.eye_close3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_close3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_close3.FlatAppearance.BorderSize = 0;
            this.eye_close3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_close3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_close3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_close3.Location = new System.Drawing.Point(638, 474);
            this.eye_close3.Name = "eye_close3";
            this.eye_close3.Size = new System.Drawing.Size(35, 35);
            this.eye_close3.TabIndex = 10;
            this.eye_close3.UseVisualStyleBackColor = false;
            // 
            // eye_open2
            // 
            this.eye_open2.BackColor = System.Drawing.Color.Transparent;
            this.eye_open2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_open2.BackgroundImage")));
            this.eye_open2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_open2.CausesValidation = false;
            this.eye_open2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_open2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_open2.FlatAppearance.BorderSize = 0;
            this.eye_open2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_open2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_open2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_open2.Location = new System.Drawing.Point(636, 394);
            this.eye_open2.Name = "eye_open2";
            this.eye_open2.Size = new System.Drawing.Size(35, 35);
            this.eye_open2.TabIndex = 7;
            this.eye_open2.UseVisualStyleBackColor = false;
            // 
            // eye_close2
            // 
            this.eye_close2.BackColor = System.Drawing.Color.Transparent;
            this.eye_close2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_close2.BackgroundImage")));
            this.eye_close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_close2.CausesValidation = false;
            this.eye_close2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_close2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_close2.FlatAppearance.BorderSize = 0;
            this.eye_close2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_close2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_close2.Location = new System.Drawing.Point(638, 394);
            this.eye_close2.Name = "eye_close2";
            this.eye_close2.Size = new System.Drawing.Size(35, 35);
            this.eye_close2.TabIndex = 8;
            this.eye_close2.UseVisualStyleBackColor = false;
            // 
            // confirm_pass_txb
            // 
            this.confirm_pass_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_pass_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.confirm_pass_txb.Location = new System.Drawing.Point(293, 474);
            this.confirm_pass_txb.Name = "confirm_pass_txb";
            this.confirm_pass_txb.Size = new System.Drawing.Size(339, 34);
            this.confirm_pass_txb.TabIndex = 6;
            this.confirm_pass_txb.Text = "Confirm Password";
            // 
            // email_txb
            // 
            this.email_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.email_txb.Location = new System.Drawing.Point(293, 240);
            this.email_txb.Name = "email_txb";
            this.email_txb.Size = new System.Drawing.Size(380, 34);
            this.email_txb.TabIndex = 5;
            this.email_txb.Text = "Email";
            // 
            // username2_txb
            // 
            this.username2_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username2_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username2_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.username2_txb.Location = new System.Drawing.Point(293, 319);
            this.username2_txb.Name = "username2_txb";
            this.username2_txb.Size = new System.Drawing.Size(380, 34);
            this.username2_txb.TabIndex = 4;
            this.username2_txb.Text = "Username";
            // 
            // password2_txb
            // 
            this.password2_txb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password2_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.password2_txb.Location = new System.Drawing.Point(293, 397);
            this.password2_txb.Name = "password2_txb";
            this.password2_txb.Size = new System.Drawing.Size(337, 34);
            this.password2_txb.TabIndex = 3;
            this.password2_txb.Text = "Password";
            // 
            // signIn_btn
            // 
            this.signIn_btn.AutoSize = true;
            this.signIn_btn.BackColor = System.Drawing.Color.Transparent;
            this.signIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.signIn_btn.Location = new System.Drawing.Point(561, 610);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(94, 29);
            this.signIn_btn.TabIndex = 2;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // create_acc_btn
            // 
            this.create_acc_btn.BackColor = System.Drawing.Color.Transparent;
            this.create_acc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_acc_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.create_acc_btn.FlatAppearance.BorderSize = 0;
            this.create_acc_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.create_acc_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.create_acc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_acc_btn.Location = new System.Drawing.Point(340, 534);
            this.create_acc_btn.Name = "create_acc_btn";
            this.create_acc_btn.Size = new System.Drawing.Size(300, 62);
            this.create_acc_btn.TabIndex = 1;
            this.create_acc_btn.UseVisualStyleBackColor = false;
            this.create_acc_btn.Click += new System.EventHandler(this.create_acc_btn_Click);
            // 
            // eye_close1
            // 
            this.eye_close1.BackColor = System.Drawing.Color.Transparent;
            this.eye_close1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eye_close1.BackgroundImage")));
            this.eye_close1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eye_close1.CausesValidation = false;
            this.eye_close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eye_close1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.eye_close1.FlatAppearance.BorderSize = 0;
            this.eye_close1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eye_close1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eye_close1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye_close1.Location = new System.Drawing.Point(654, 401);
            this.eye_close1.Name = "eye_close1";
            this.eye_close1.Size = new System.Drawing.Size(35, 35);
            this.eye_close1.TabIndex = 6;
            this.eye_close1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.Login_page);
            this.Controls.Add(this.Signup_page);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Login_page.ResumeLayout(false);
            this.Login_page.PerformLayout();
            this.Signup_page.ResumeLayout(false);
            this.Signup_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_page;
        private System.Windows.Forms.Button eye_open1;
        private System.Windows.Forms.Label signUp_btn;
        private System.Windows.Forms.TextBox password1_txb;
        private System.Windows.Forms.TextBox username1_txb;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.Panel Signup_page;
        private System.Windows.Forms.Button eye_open3;
        private System.Windows.Forms.Button eye_close3;
        private System.Windows.Forms.Button eye_open2;
        private System.Windows.Forms.Button eye_close2;
        private System.Windows.Forms.TextBox confirm_pass_txb;
        private System.Windows.Forms.TextBox email_txb;
        private System.Windows.Forms.TextBox username2_txb;
        private System.Windows.Forms.TextBox password2_txb;
        private System.Windows.Forms.Label signIn_btn;
        private System.Windows.Forms.Button create_acc_btn;
        private System.Windows.Forms.Button eye_close1;
    }
}

