namespace Entrance_Application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_rights = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_rights = new System.Windows.Forms.ComboBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_currentTime = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(216, 154);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(65, 13);
            this.lb_password.TabIndex = 14;
            this.lb_password.Text = "Password:";
            // 
            // lb_rights
            // 
            this.lb_rights.AutoSize = true;
            this.lb_rights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rights.Location = new System.Drawing.Point(216, 110);
            this.lb_rights.Name = "lb_rights";
            this.lb_rights.Size = new System.Drawing.Size(47, 13);
            this.lb_rights.TabIndex = 13;
            this.lb_rights.Text = "Rights:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(239, 207);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(216, 170);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(121, 20);
            this.tb_password.TabIndex = 11;
            // 
            // cb_rights
            // 
            this.cb_rights.FormattingEnabled = true;
            this.cb_rights.Items.AddRange(new object[] {
            "Administrator",
            "Shop seller",
            "Entrance staff",
            "Camping staff"});
            this.cb_rights.Location = new System.Drawing.Point(216, 126);
            this.cb_rights.Name = "cb_rights";
            this.cb_rights.Size = new System.Drawing.Size(121, 21);
            this.cb_rights.TabIndex = 10;
            // 
            // pb_login
            // 
            this.pb_login.Image = global::Entrance_Application.Properties.Resources.Login;
            this.pb_login.Location = new System.Drawing.Point(25, 107);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(150, 123);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 9;
            this.pb_login.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lb_currentTime);
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 85);
            this.panel1.TabIndex = 8;
            // 
            // lb_currentTime
            // 
            this.lb_currentTime.AutoSize = true;
            this.lb_currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentTime.ForeColor = System.Drawing.Color.White;
            this.lb_currentTime.Location = new System.Drawing.Point(1143, 59);
            this.lb_currentTime.Name = "lb_currentTime";
            this.lb_currentTime.Size = new System.Drawing.Size(41, 15);
            this.lb_currentTime.TabIndex = 3;
            this.lb_currentTime.Text = "label6";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::Entrance_Application.Properties.Resources.staticLogo;
            this.pb_logo.Location = new System.Drawing.Point(279, 6);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(91, 76);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_rights);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.cb_rights);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_rights;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ComboBox cb_rights;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_currentTime;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label1;
    }
}