namespace Store_Application {
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lb_totalProfits = new System.Windows.Forms.Label();
            this.lb_TotalUnit = new System.Windows.Forms.Label();
            this.lb_totalItem = new System.Windows.Forms.Label();
            this.lb_storeID = new System.Windows.Forms.Label();
            this.dataGridView_StoreInfo = new System.Windows.Forms.DataGridView();
            this.btn_showInfo = new System.Windows.Forms.Button();
            this.cb_listStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gp_menuCart = new System.Windows.Forms.GroupBox();
            this.layout_item = new System.Windows.Forms.TableLayoutPanel();
            this.btn_snacks = new System.Windows.Forms.Button();
            this.btn_sweets = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_dink = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_printBil = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dt_cart = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_rfid_purchase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_charger = new System.Windows.Forms.Button();
            this.btn_powerBank = new System.Windows.Forms.Button();
            this.btn_otherItems = new System.Windows.Forms.Button();
            this.btn_camera = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_rental = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_printTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StoreInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gp_menuCart.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rental)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1618, 133);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(761, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 831);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1618, 84);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(822, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Rights Reserved © G5 Software Solutions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 133);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1618, 698);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1610, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_printTable);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.lb_totalProfits);
            this.groupBox1.Controls.Add(this.lb_TotalUnit);
            this.groupBox1.Controls.Add(this.lb_totalItem);
            this.groupBox1.Controls.Add(this.lb_storeID);
            this.groupBox1.Controls.Add(this.dataGridView_StoreInfo);
            this.groupBox1.Controls.Add(this.btn_showInfo);
            this.groupBox1.Controls.Add(this.cb_listStore);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1573, 756);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Info";
            // 
            // btn_update
            // 
            this.btn_update.ImageIndex = 5;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(164, 292);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(116, 70);
            this.btn_update.TabIndex = 13;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // lb_totalProfits
            // 
            this.lb_totalProfits.AutoSize = true;
            this.lb_totalProfits.Location = new System.Drawing.Point(478, 210);
            this.lb_totalProfits.Name = "lb_totalProfits";
            this.lb_totalProfits.Size = new System.Drawing.Size(62, 20);
            this.lb_totalProfits.TabIndex = 12;
            this.lb_totalProfits.Text = "label15";
            // 
            // lb_TotalUnit
            // 
            this.lb_TotalUnit.AutoSize = true;
            this.lb_TotalUnit.Location = new System.Drawing.Point(575, 176);
            this.lb_TotalUnit.Name = "lb_TotalUnit";
            this.lb_TotalUnit.Size = new System.Drawing.Size(62, 20);
            this.lb_TotalUnit.TabIndex = 11;
            this.lb_TotalUnit.Text = "label14";
            // 
            // lb_totalItem
            // 
            this.lb_totalItem.AutoSize = true;
            this.lb_totalItem.Location = new System.Drawing.Point(478, 142);
            this.lb_totalItem.Name = "lb_totalItem";
            this.lb_totalItem.Size = new System.Drawing.Size(62, 20);
            this.lb_totalItem.TabIndex = 10;
            this.lb_totalItem.Text = "label13";
            // 
            // lb_storeID
            // 
            this.lb_storeID.AutoSize = true;
            this.lb_storeID.Location = new System.Drawing.Point(478, 111);
            this.lb_storeID.Name = "lb_storeID";
            this.lb_storeID.Size = new System.Drawing.Size(62, 20);
            this.lb_storeID.TabIndex = 9;
            this.lb_storeID.Text = "label10";
            // 
            // dataGridView_StoreInfo
            // 
            this.dataGridView_StoreInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StoreInfo.Location = new System.Drawing.Point(334, 264);
            this.dataGridView_StoreInfo.Name = "dataGridView_StoreInfo";
            this.dataGridView_StoreInfo.RowTemplate.Height = 28;
            this.dataGridView_StoreInfo.Size = new System.Drawing.Size(1162, 413);
            this.dataGridView_StoreInfo.TabIndex = 8;
            this.dataGridView_StoreInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StoreInfo_CellContentClick);
            this.dataGridView_StoreInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StoreInfo_CellValueChanged);
            // 
            // btn_showInfo
            // 
            this.btn_showInfo.Location = new System.Drawing.Point(735, 68);
            this.btn_showInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_showInfo.Name = "btn_showInfo";
            this.btn_showInfo.Size = new System.Drawing.Size(154, 35);
            this.btn_showInfo.TabIndex = 7;
            this.btn_showInfo.Text = "Show Info";
            this.btn_showInfo.UseVisualStyleBackColor = true;
            this.btn_showInfo.Click += new System.EventHandler(this.btn_showInfo_Click);
            // 
            // cb_listStore
            // 
            this.cb_listStore.FormattingEnabled = true;
            this.cb_listStore.Location = new System.Drawing.Point(345, 71);
            this.cb_listStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_listStore.Name = "cb_listStore";
            this.cb_listStore.Size = new System.Drawing.Size(379, 28);
            this.cb_listStore.TabIndex = 6;
            this.cb_listStore.Text = "Choose a store";
            this.cb_listStore.SelectedIndexChanged += new System.EventHandler(this.cb_listStore_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total Profits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Units Sold/Loaned:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Items:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Store ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gp_menuCart);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1610, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sale Store";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gp_menuCart
            // 
            this.gp_menuCart.Controls.Add(this.layout_item);
            this.gp_menuCart.Controls.Add(this.btn_snacks);
            this.gp_menuCart.Controls.Add(this.btn_sweets);
            this.gp_menuCart.Controls.Add(this.btn_food);
            this.gp_menuCart.Controls.Add(this.btn_dink);
            this.gp_menuCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.gp_menuCart.Location = new System.Drawing.Point(4, 5);
            this.gp_menuCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_menuCart.Name = "gp_menuCart";
            this.gp_menuCart.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_menuCart.Size = new System.Drawing.Size(1028, 655);
            this.gp_menuCart.TabIndex = 26;
            this.gp_menuCart.TabStop = false;
            this.gp_menuCart.Text = "Menucart";
            // 
            // layout_item
            // 
            this.layout_item.ColumnCount = 3;
            this.layout_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_item.Location = new System.Drawing.Point(78, 229);
            this.layout_item.Name = "layout_item";
            this.layout_item.RowCount = 2;
            this.layout_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_item.Size = new System.Drawing.Size(773, 353);
            this.layout_item.TabIndex = 32;
            // 
            // btn_snacks
            // 
            this.btn_snacks.BackColor = System.Drawing.Color.DarkGray;
            this.btn_snacks.Location = new System.Drawing.Point(319, 97);
            this.btn_snacks.Name = "btn_snacks";
            this.btn_snacks.Size = new System.Drawing.Size(117, 79);
            this.btn_snacks.TabIndex = 31;
            this.btn_snacks.Text = "Snacks";
            this.btn_snacks.UseVisualStyleBackColor = false;
            this.btn_snacks.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_sweets
            // 
            this.btn_sweets.BackColor = System.Drawing.Color.DarkGray;
            this.btn_sweets.Location = new System.Drawing.Point(466, 97);
            this.btn_sweets.Name = "btn_sweets";
            this.btn_sweets.Size = new System.Drawing.Size(114, 79);
            this.btn_sweets.TabIndex = 30;
            this.btn_sweets.Text = "Sweets";
            this.btn_sweets.UseVisualStyleBackColor = false;
            this.btn_sweets.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_food
            // 
            this.btn_food.BackColor = System.Drawing.Color.DarkGray;
            this.btn_food.Location = new System.Drawing.Point(609, 97);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(116, 79);
            this.btn_food.TabIndex = 29;
            this.btn_food.Text = "Food";
            this.btn_food.UseVisualStyleBackColor = false;
            this.btn_food.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_dink
            // 
            this.btn_dink.BackColor = System.Drawing.Color.DarkGray;
            this.btn_dink.Location = new System.Drawing.Point(166, 97);
            this.btn_dink.Name = "btn_dink";
            this.btn_dink.Size = new System.Drawing.Size(124, 79);
            this.btn_dink.TabIndex = 28;
            this.btn_dink.Text = "Drinks";
            this.btn_dink.UseVisualStyleBackColor = false;
            this.btn_dink.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_printBil);
            this.groupBox4.Controls.Add(this.lb_total);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dt_cart);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(970, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(636, 655);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shopping Cart";
            // 
            // btn_printBil
            // 
            this.btn_printBil.Location = new System.Drawing.Point(466, 620);
            this.btn_printBil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_printBil.Name = "btn_printBil";
            this.btn_printBil.Size = new System.Drawing.Size(143, 36);
            this.btn_printBil.TabIndex = 30;
            this.btn_printBil.Text = "Print bill";
            this.btn_printBil.UseVisualStyleBackColor = true;
            this.btn_printBil.Click += new System.EventHandler(this.btn_printBil_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(488, 584);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(60, 20);
            this.lb_total.TabIndex = 29;
            this.lb_total.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 584);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total";
            // 
            // dt_cart
            // 
            this.dt_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_cart.Location = new System.Drawing.Point(102, 155);
            this.dt_cart.Name = "dt_cart";
            this.dt_cart.RowTemplate.Height = 28;
            this.dt_cart.Size = new System.Drawing.Size(507, 370);
            this.dt_cart.TabIndex = 28;
            this.dt_cart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_cart_CellDoubleClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(386, 91);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 35);
            this.button10.TabIndex = 27;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 639);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Proceed to payment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_rfid_purchase);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(132, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(305, 95);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bracelet Info";
            // 
            // lb_rfid_purchase
            // 
            this.lb_rfid_purchase.AutoSize = true;
            this.lb_rfid_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rfid_purchase.Location = new System.Drawing.Point(105, 25);
            this.lb_rfid_purchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rfid_purchase.Name = "lb_rfid_purchase";
            this.lb_rfid_purchase.Size = new System.Drawing.Size(58, 20);
            this.lb_rfid_purchase.TabIndex = 9;
            this.lb_rfid_purchase.Text = "RFID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "RFID:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1610, 665);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental Store";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Controls.Add(this.btn_charger);
            this.groupBox5.Controls.Add(this.btn_powerBank);
            this.groupBox5.Controls.Add(this.btn_otherItems);
            this.groupBox5.Controls.Add(this.btn_camera);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1034, 665);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(645, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 79);
            this.button1.TabIndex = 37;
            this.button1.Text = "LENS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 274);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 285);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // btn_charger
            // 
            this.btn_charger.BackColor = System.Drawing.Color.DarkGray;
            this.btn_charger.Location = new System.Drawing.Point(354, 86);
            this.btn_charger.Name = "btn_charger";
            this.btn_charger.Size = new System.Drawing.Size(117, 79);
            this.btn_charger.TabIndex = 35;
            this.btn_charger.Text = "CHARGER";
            this.btn_charger.UseVisualStyleBackColor = false;
            this.btn_charger.Click += new System.EventHandler(this.btn_charger_Click);
            // 
            // btn_powerBank
            // 
            this.btn_powerBank.BackColor = System.Drawing.Color.DarkGray;
            this.btn_powerBank.Location = new System.Drawing.Point(501, 86);
            this.btn_powerBank.Name = "btn_powerBank";
            this.btn_powerBank.Size = new System.Drawing.Size(114, 79);
            this.btn_powerBank.TabIndex = 34;
            this.btn_powerBank.Text = "POWER BANK";
            this.btn_powerBank.UseVisualStyleBackColor = false;
            this.btn_powerBank.Click += new System.EventHandler(this.btn_powerBank_Click);
            // 
            // btn_otherItems
            // 
            this.btn_otherItems.BackColor = System.Drawing.Color.DarkGray;
            this.btn_otherItems.Location = new System.Drawing.Point(783, 86);
            this.btn_otherItems.Name = "btn_otherItems";
            this.btn_otherItems.Size = new System.Drawing.Size(116, 79);
            this.btn_otherItems.TabIndex = 33;
            this.btn_otherItems.Text = "OTHER ITEMS";
            this.btn_otherItems.UseVisualStyleBackColor = false;
            this.btn_otherItems.Click += new System.EventHandler(this.btn_otherItems_Click);
            // 
            // btn_camera
            // 
            this.btn_camera.BackColor = System.Drawing.Color.DarkGray;
            this.btn_camera.Location = new System.Drawing.Point(201, 86);
            this.btn_camera.Name = "btn_camera";
            this.btn_camera.Size = new System.Drawing.Size(124, 79);
            this.btn_camera.TabIndex = 32;
            this.btn_camera.Text = "CAMERA";
            this.btn_camera.UseVisualStyleBackColor = false;
            this.btn_camera.Click += new System.EventHandler(this.btn_camera_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dt_rental);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1069, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 665);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(304, 604);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(241, 35);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Print receipt";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "label15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total";
            // 
            // dt_rental
            // 
            this.dt_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_rental.Location = new System.Drawing.Point(26, 216);
            this.dt_rental.Name = "dt_rental";
            this.dt_rental.RowTemplate.Height = 28;
            this.dt_rental.Size = new System.Drawing.Size(507, 309);
            this.dt_rental.TabIndex = 29;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Location = new System.Drawing.Point(38, 86);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(259, 67);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Bracelet Info";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(9, 42);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 20);
            this.label36.TabIndex = 8;
            this.label36.Text = "RFID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 604);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Proceed to payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 57);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bitmap.ico");
            this.imageList1.Images.SetKeyName(1, "print.ico");
            this.imageList1.Images.SetKeyName(2, "Search.ico");
            this.imageList1.Images.SetKeyName(3, "statistics.ico");
            this.imageList1.Images.SetKeyName(4, "visitors.ico");
            this.imageList1.Images.SetKeyName(5, "trashbin.ico");
            // 
            // btn_printTable
            // 
            this.btn_printTable.ImageIndex = 1;
            this.btn_printTable.ImageList = this.imageList1;
            this.btn_printTable.Location = new System.Drawing.Point(164, 388);
            this.btn_printTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_printTable.Name = "btn_printTable";
            this.btn_printTable.Size = new System.Drawing.Size(116, 70);
            this.btn_printTable.TabIndex = 14;
            this.btn_printTable.UseVisualStyleBackColor = true;
            this.btn_printTable.Click += new System.EventHandler(this.btn_printTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 915);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Store Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StoreInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gp_menuCart.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rental)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_showInfo;
        private System.Windows.Forms.ComboBox cb_listStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox gp_menuCart;
        private System.Windows.Forms.Label lb_totalProfits;
        private System.Windows.Forms.Label lb_TotalUnit;
        private System.Windows.Forms.Label lb_totalItem;
        private System.Windows.Forms.Label lb_storeID;
        private System.Windows.Forms.DataGridView dataGridView_StoreInfo;
        private System.Windows.Forms.Button btn_snacks;
        private System.Windows.Forms.Button btn_sweets;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_dink;
        private System.Windows.Forms.TableLayoutPanel layout_item;
        private System.Windows.Forms.DataGridView dt_cart;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_charger;
        private System.Windows.Forms.Button btn_powerBank;
        private System.Windows.Forms.Button btn_otherItems;
        private System.Windows.Forms.Button btn_camera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_rental;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_printBil;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lb_rfid_purchase;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_printTable;
    }
}

