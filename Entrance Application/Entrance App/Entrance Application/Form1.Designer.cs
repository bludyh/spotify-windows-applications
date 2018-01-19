namespace Entrance_Application {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_currentTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_spotTrue = new System.Windows.Forms.RadioButton();
            this.rb_spotFalse = new System.Windows.Forms.RadioButton();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lb_Overview = new System.Windows.Forms.ListBox();
            this.btn_addPerson = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.gb_shoppingCart = new System.Windows.Forms.GroupBox();
            this.lb_limit = new System.Windows.Forms.Label();
            this.lb_spotFull = new System.Windows.Forms.Label();
            this.lb_reservationQuan = new System.Windows.Forms.Label();
            this.lb_campingQuan = new System.Windows.Forms.Label();
            this.lb_ticketQuan = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_Quan = new System.Windows.Forms.Label();
            this.lb_Item = new System.Windows.Forms.Label();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.lb_totalTitle = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lb_reservationPrice = new System.Windows.Forms.Label();
            this.lb_campingPrice = new System.Windows.Forms.Label();
            this.lb_ticketPrice = new System.Windows.Forms.Label();
            this.lb_reservationTitle = new System.Windows.Forms.Label();
            this.lb_campingTitle = new System.Windows.Forms.Label();
            this.lb_ticketTitle = new System.Windows.Forms.Label();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gb_shoppingCart.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lb_currentTime);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 118);
            this.panel1.TabIndex = 0;
            // 
            // lb_currentTime
            // 
            this.lb_currentTime.AutoSize = true;
            this.lb_currentTime.ForeColor = System.Drawing.Color.White;
            this.lb_currentTime.Location = new System.Drawing.Point(1121, 62);
            this.lb_currentTime.Name = "lb_currentTime";
            this.lb_currentTime.Size = new System.Drawing.Size(41, 13);
            this.lb_currentTime.TabIndex = 3;
            this.lb_currentTime.Text = "label22";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrance Control Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.rb_spotTrue);
            this.tabPage2.Controls.Add(this.rb_spotFalse);
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.btn_Remove);
            this.tabPage2.Controls.Add(this.lb_Overview);
            this.tabPage2.Controls.Add(this.btn_addPerson);
            this.tabPage2.Controls.Add(this.btn_proceed);
            this.tabPage2.Controls.Add(this.gb_shoppingCart);
            this.tabPage2.Controls.Add(this.tb_lname);
            this.tabPage2.Controls.Add(this.dt_dob);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tb_fname);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1269, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buy Tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_spotTrue
            // 
            this.rb_spotTrue.AutoSize = true;
            this.rb_spotTrue.Location = new System.Drawing.Point(300, 191);
            this.rb_spotTrue.Name = "rb_spotTrue";
            this.rb_spotTrue.Size = new System.Drawing.Size(131, 17);
            this.rb_spotTrue.TabIndex = 4;
            this.rb_spotTrue.TabStop = true;
            this.rb_spotTrue.Text = "Reserve camping spot";
            this.rb_spotTrue.UseVisualStyleBackColor = true;
            // 
            // rb_spotFalse
            // 
            this.rb_spotFalse.AutoSize = true;
            this.rb_spotFalse.Location = new System.Drawing.Point(143, 191);
            this.rb_spotFalse.Name = "rb_spotFalse";
            this.rb_spotFalse.Size = new System.Drawing.Size(154, 17);
            this.rb_spotFalse.TabIndex = 3;
            this.rb_spotFalse.TabStop = true;
            this.rb_spotFalse.Text = "Don\'t reserve camping spot";
            this.rb_spotFalse.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(303, 225);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 28);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.ImageKey = "(none)";
            this.btn_Remove.Location = new System.Drawing.Point(754, 288);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(31, 147);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lb_Overview
            // 
            this.lb_Overview.FormattingEnabled = true;
            this.lb_Overview.Location = new System.Drawing.Point(131, 288);
            this.lb_Overview.Name = "lb_Overview";
            this.lb_Overview.Size = new System.Drawing.Size(617, 147);
            this.lb_Overview.TabIndex = 19;
            // 
            // btn_addPerson
            // 
            this.btn_addPerson.Location = new System.Drawing.Point(131, 225);
            this.btn_addPerson.Name = "btn_addPerson";
            this.btn_addPerson.Size = new System.Drawing.Size(160, 28);
            this.btn_addPerson.TabIndex = 5;
            this.btn_addPerson.Text = "Add another person";
            this.btn_addPerson.UseVisualStyleBackColor = true;
            this.btn_addPerson.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_proceed.Location = new System.Drawing.Point(935, 402);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(304, 28);
            this.btn_proceed.TabIndex = 8;
            this.btn_proceed.Text = "Proceed to payment";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.button3_Click);
            // 
            // gb_shoppingCart
            // 
            this.gb_shoppingCart.Controls.Add(this.lb_limit);
            this.gb_shoppingCart.Controls.Add(this.lb_spotFull);
            this.gb_shoppingCart.Controls.Add(this.lb_reservationQuan);
            this.gb_shoppingCart.Controls.Add(this.lb_campingQuan);
            this.gb_shoppingCart.Controls.Add(this.lb_ticketQuan);
            this.gb_shoppingCart.Controls.Add(this.lb_Price);
            this.gb_shoppingCart.Controls.Add(this.lb_Quan);
            this.gb_shoppingCart.Controls.Add(this.lb_Item);
            this.gb_shoppingCart.Controls.Add(this.lb_totalPrice);
            this.gb_shoppingCart.Controls.Add(this.lb_totalTitle);
            this.gb_shoppingCart.Controls.Add(this.label26);
            this.gb_shoppingCart.Controls.Add(this.lb_reservationPrice);
            this.gb_shoppingCart.Controls.Add(this.lb_campingPrice);
            this.gb_shoppingCart.Controls.Add(this.lb_ticketPrice);
            this.gb_shoppingCart.Controls.Add(this.lb_reservationTitle);
            this.gb_shoppingCart.Controls.Add(this.lb_campingTitle);
            this.gb_shoppingCart.Controls.Add(this.lb_ticketTitle);
            this.gb_shoppingCart.Location = new System.Drawing.Point(935, 26);
            this.gb_shoppingCart.Name = "gb_shoppingCart";
            this.gb_shoppingCart.Size = new System.Drawing.Size(304, 370);
            this.gb_shoppingCart.TabIndex = 14;
            this.gb_shoppingCart.TabStop = false;
            this.gb_shoppingCart.Text = "Shopping Cart";
            // 
            // lb_limit
            // 
            this.lb_limit.AutoSize = true;
            this.lb_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_limit.ForeColor = System.Drawing.Color.Red;
            this.lb_limit.Location = new System.Drawing.Point(187, 80);
            this.lb_limit.Name = "lb_limit";
            this.lb_limit.Size = new System.Drawing.Size(48, 13);
            this.lb_limit.TabIndex = 16;
            this.lb_limit.Text = "label22";
            // 
            // lb_spotFull
            // 
            this.lb_spotFull.AutoSize = true;
            this.lb_spotFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_spotFull.ForeColor = System.Drawing.Color.Red;
            this.lb_spotFull.Location = new System.Drawing.Point(187, 129);
            this.lb_spotFull.Name = "lb_spotFull";
            this.lb_spotFull.Size = new System.Drawing.Size(48, 13);
            this.lb_spotFull.TabIndex = 15;
            this.lb_spotFull.Text = "label21";
            // 
            // lb_reservationQuan
            // 
            this.lb_reservationQuan.AutoSize = true;
            this.lb_reservationQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reservationQuan.Location = new System.Drawing.Point(172, 172);
            this.lb_reservationQuan.Name = "lb_reservationQuan";
            this.lb_reservationQuan.Size = new System.Drawing.Size(18, 20);
            this.lb_reservationQuan.TabIndex = 14;
            this.lb_reservationQuan.Text = "0";
            // 
            // lb_campingQuan
            // 
            this.lb_campingQuan.AutoSize = true;
            this.lb_campingQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_campingQuan.Location = new System.Drawing.Point(172, 126);
            this.lb_campingQuan.Name = "lb_campingQuan";
            this.lb_campingQuan.Size = new System.Drawing.Size(18, 20);
            this.lb_campingQuan.TabIndex = 13;
            this.lb_campingQuan.Text = "0";
            // 
            // lb_ticketQuan
            // 
            this.lb_ticketQuan.AutoSize = true;
            this.lb_ticketQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ticketQuan.Location = new System.Drawing.Point(172, 77);
            this.lb_ticketQuan.Name = "lb_ticketQuan";
            this.lb_ticketQuan.Size = new System.Drawing.Size(18, 20);
            this.lb_ticketQuan.TabIndex = 12;
            this.lb_ticketQuan.Text = "0";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.Location = new System.Drawing.Point(228, 33);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(58, 24);
            this.lb_Price.TabIndex = 11;
            this.lb_Price.Text = "Price";
            // 
            // lb_Quan
            // 
            this.lb_Quan.AutoSize = true;
            this.lb_Quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quan.Location = new System.Drawing.Point(117, 33);
            this.lb_Quan.Name = "lb_Quan";
            this.lb_Quan.Size = new System.Drawing.Size(86, 24);
            this.lb_Quan.TabIndex = 10;
            this.lb_Quan.Text = "Quantity";
            // 
            // lb_Item
            // 
            this.lb_Item.AutoSize = true;
            this.lb_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item.Location = new System.Drawing.Point(15, 33);
            this.lb_Item.Name = "lb_Item";
            this.lb_Item.Size = new System.Drawing.Size(49, 24);
            this.lb_Item.TabIndex = 9;
            this.lb_Item.Text = "Item";
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPrice.Location = new System.Drawing.Point(161, 262);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(29, 20);
            this.lb_totalPrice.TabIndex = 8;
            this.lb_totalPrice.Text = "€0";
            // 
            // lb_totalTitle
            // 
            this.lb_totalTitle.AutoSize = true;
            this.lb_totalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalTitle.Location = new System.Drawing.Point(14, 262);
            this.lb_totalTitle.Name = "lb_totalTitle";
            this.lb_totalTitle.Size = new System.Drawing.Size(49, 20);
            this.lb_totalTitle.TabIndex = 7;
            this.lb_totalTitle.Text = "Total";
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Location = new System.Drawing.Point(8, 246);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(290, 2);
            this.label26.TabIndex = 6;
            // 
            // lb_reservationPrice
            // 
            this.lb_reservationPrice.AutoSize = true;
            this.lb_reservationPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reservationPrice.Location = new System.Drawing.Point(241, 172);
            this.lb_reservationPrice.Name = "lb_reservationPrice";
            this.lb_reservationPrice.Size = new System.Drawing.Size(27, 20);
            this.lb_reservationPrice.TabIndex = 5;
            this.lb_reservationPrice.Text = "€0";
            // 
            // lb_campingPrice
            // 
            this.lb_campingPrice.AutoSize = true;
            this.lb_campingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_campingPrice.Location = new System.Drawing.Point(241, 126);
            this.lb_campingPrice.Name = "lb_campingPrice";
            this.lb_campingPrice.Size = new System.Drawing.Size(27, 20);
            this.lb_campingPrice.TabIndex = 4;
            this.lb_campingPrice.Text = "€0";
            // 
            // lb_ticketPrice
            // 
            this.lb_ticketPrice.AutoSize = true;
            this.lb_ticketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ticketPrice.Location = new System.Drawing.Point(241, 76);
            this.lb_ticketPrice.Name = "lb_ticketPrice";
            this.lb_ticketPrice.Size = new System.Drawing.Size(27, 20);
            this.lb_ticketPrice.TabIndex = 3;
            this.lb_ticketPrice.Text = "€0";
            // 
            // lb_reservationTitle
            // 
            this.lb_reservationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reservationTitle.Location = new System.Drawing.Point(16, 160);
            this.lb_reservationTitle.Name = "lb_reservationTitle";
            this.lb_reservationTitle.Size = new System.Drawing.Size(122, 44);
            this.lb_reservationTitle.TabIndex = 2;
            this.lb_reservationTitle.Text = "Camping spot reservation cost";
            // 
            // lb_campingTitle
            // 
            this.lb_campingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_campingTitle.Location = new System.Drawing.Point(16, 109);
            this.lb_campingTitle.Name = "lb_campingTitle";
            this.lb_campingTitle.Size = new System.Drawing.Size(139, 73);
            this.lb_campingTitle.TabIndex = 1;
            this.lb_campingTitle.Text = "Person(s) (camping spot)";
            // 
            // lb_ticketTitle
            // 
            this.lb_ticketTitle.AutoSize = true;
            this.lb_ticketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ticketTitle.Location = new System.Drawing.Point(13, 77);
            this.lb_ticketTitle.Name = "lb_ticketTitle";
            this.lb_ticketTitle.Size = new System.Drawing.Size(69, 20);
            this.lb_ticketTitle.TabIndex = 0;
            this.lb_ticketTitle.Text = "Ticket(s)";
            // 
            // tb_lname
            // 
            this.tb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lname.Location = new System.Drawing.Point(476, 55);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(272, 31);
            this.tb_lname.TabIndex = 1;
            // 
            // dt_dob
            // 
            this.dt_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dob.Location = new System.Drawing.Point(142, 126);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(228, 20);
            this.dt_dob.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(138, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Date Of Birth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(472, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Last Name";
            // 
            // tb_fname
            // 
            this.tb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fname.Location = new System.Drawing.Point(142, 55);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(272, 31);
            this.tb_fname.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-32, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 97);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(597, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Rights Reserved © G5 Software Solutions";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gb_shoppingCart.ResumeLayout(false);
            this.gb_shoppingCart.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.Button btn_addPerson;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.GroupBox gb_shoppingCart;
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Label lb_totalTitle;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lb_reservationPrice;
        private System.Windows.Forms.Label lb_campingPrice;
        private System.Windows.Forms.Label lb_ticketPrice;
        private System.Windows.Forms.Label lb_reservationTitle;
        private System.Windows.Forms.Label lb_campingTitle;
        private System.Windows.Forms.Label lb_ticketTitle;
        private System.Windows.Forms.Label lb_reservationQuan;
        private System.Windows.Forms.Label lb_campingQuan;
        private System.Windows.Forms.Label lb_ticketQuan;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_Quan;
        private System.Windows.Forms.Label lb_Item;
        private System.Windows.Forms.Label lb_spotFull;
        private System.Windows.Forms.ListBox lb_Overview;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RadioButton rb_spotTrue;
        private System.Windows.Forms.RadioButton rb_spotFalse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_currentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_limit;
    }
}

