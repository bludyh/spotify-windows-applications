using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Application {
    public partial class Form1 : Form {

        private DataHelper dh;
        private List<Store> listStore;
        private List<Item> listItem= new List<Item>();
        private AdjustQuantity adjust;
        //test 27.11
        private int count = 0;
        public Form1() {
            InitializeComponent();
            dh = new DataHelper();
            listStore = new List<Store>();
            LoadStoreToCombobox();
            dataGridView_StoreInfo.Visible = false;

            btn_printTable.Visible = btn_update.Visible = false;

            //full screen
            this.WindowState = FormWindowState.Maximized;

            //creat columns for datagridview Cart
            this.dt_cart.Columns.Add("Item", "Item");
            this.dt_cart.Columns.Add("Quantity", "Quantity");
            this.dt_cart.Columns.Add("Price", "Price");
        }

        private void btn_showInfo_Click(object sender, EventArgs e)
        {
            if (cb_listStore.Text == "Choose a store")
            {
                MessageBox.Show("No store selected","Attention!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                btn_update.Visible = btn_printTable.Visible = true;
                int index = cb_listStore.SelectedIndex;
                Store temp = listStore[index];
                //List<string> listInfo = dh.getStoreInfo(temp.ID);
                lb_storeID.Text = temp.ID.ToString();
                lb_totalItem.Text = dh.getStoreInfo(temp.ID).ToString();
                dataGridView_StoreInfo.DataSource = dh.getDataOfAStore(temp.ID);
                dataGridView_StoreInfo.Visible = true;
                lb_totalProfits.Text = dh.GetProfitByStoreId(temp.ID).ToString() + " EUROS";
                lb_TotalUnit.Text = dh.GetUnitSoldOrLoaned(temp.ID).ToString() + " units";
            }
        }
        //Load all store to combobox
        public void LoadStoreToCombobox() {
            listStore = dh.getListOfStore();
            foreach (Store s in listStore) {
                cb_listStore.Items.Add(s.ToString());
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView_StoreInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_listStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
       


        //Load all items for Sweets
        private void button9_Click(object sender, EventArgs e)
        {
            layout_item.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("SWEETS"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                layout_item.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }
       
        //Load all items for DRINK
        private void button1_Click(object sender, EventArgs e)
        {    
            layout_item.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
           // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("DRINK"))
            {
                
                    myButton = new Button();
                    myButton.Location = new System.Drawing.Point(x, y);
                    myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                    myButton.Text = ds.Item_name;
                    myButton.Font = myFont;
                    myButton.Tag = ds.Item_price;
                    myButton.Click += new System.EventHandler(UpdateCart);
                    layout_item.Controls.Add(myButton);

                    x = x + widthOfAButton + spaceBetweenButtons;
            }
        }
        //Load all items for food
        private void button8_Click(object sender, EventArgs e)
        {
            layout_item.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("FOOD"))
            {

                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                layout_item.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;

            }
        }
        //Load all items for snacks
        private void button12_Click(object sender, EventArgs e)
        {
            layout_item.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("SNACKS"))
            {

                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                layout_item.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;

            }
        }


        //********************EXTRA METHODS***************//

        //Update Cart
        private void UpdateCart(object sender, EventArgs e)
        {
            dt_cart.Rows.Clear();
            dt_cart.Refresh();
            // count = 1;
            decimal totalPrice = 0;
            //  decimal totalPrice = dh.GetPriceForItem(((Button)sender).Text)*count;
            Item i = new Item(0, ((Button)sender).Text, "", dh.GetPriceForItem(((Button)sender).Text), 1, 0);
            if (listItem.Count == 0)
            {
                listItem.Add(i);
                dt_cart.Rows.Add(i.Item_name, i.Item_quantity.ToString(), i.Item_quantity * i.Item_price);
                lb_total.Text = (i.Item_quantity * i.Item_price).ToString();
            }
            else
            {
                //  foreach (Item temp in listItem)
                for (int j = 0; j < listItem.Count; j++)
                {
                    //  if (temp.Item_name == i.Item_name)
                    if (listItem[j].Item_name == ((Button)sender).Text)
                    {
                        int quantity = ++listItem[j].Item_quantity;
                        listItem.Remove(listItem[j]);
                        i = new Item(0, ((Button)sender).Text, "", dh.GetPriceForItem(((Button)sender).Text), quantity, 0);
                        listItem.Add(i);
                    }
                    else
                    {
                        listItem.Add(i);
                        j = listItem.Count;
                    }
                }

                //    ////Test
                //    adjust = new AdjustQuantity();
                //adjust.Show();
                //if (adjust.GetQuantity() != -1) {
                //    Item i = new Item(0, ((Button)sender).Text,"", 0, adjust.GetQuantity(), 0);
                //    listItem.Add(i);
                //}
                foreach (Item temp1 in listItem)
                {
                    dt_cart.Rows.Add(temp1.Item_name, temp1.Item_quantity.ToString(), temp1.Item_quantity * temp1.Item_price);
                    totalPrice += (temp1.Item_quantity * temp1.Item_price);
                    lb_total.Text = totalPrice.ToString();
                }

            }

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            //int index = cb_listStore.SelectedIndex;
            //Store temp = listStore[index];
            //dh.UpdateDatagrideview(temp.ID);
            try
            {
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            int index = cb_listStore.SelectedIndex;
            Store temp = listStore[index];
            dataGridView_StoreInfo.DataSource = dh.getDataOfAStore(temp.ID);
        }

        private void dataGridView_StoreInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int index = cb_listStore.SelectedIndex;
            Store temp = listStore[index];
            dh.UpdateDatagrideview(temp.ID);
        }

        //working on now 6-12
        private void btn_camera_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("CAMERA"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                tableLayoutPanel1.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void btn_otherItems_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("OTHER ITEMS"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                tableLayoutPanel1.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void btn_charger_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("CHARGER"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                tableLayoutPanel1.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void btn_powerBank_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("POWER BANK"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                tableLayoutPanel1.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            int widthOfAButton = 231, heightOfAButton = 123;
            int spaceBetweenButtons = 10;
            int x = 3; // (x,y) is the left-top of the button
            int y = 3;
            Font myFont = new Font("Verdana", 8);

            //if you need them you may store them in an array, otherwise do it anonymously
            Button myButton;
            // int i = 0;
            foreach (Item ds in this.dh.GetListOfSpecifiedItem("LENS"))
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Item_name;
                myButton.Font = myFont;
                myButton.Tag = ds.Item_price;
                myButton.Click += new System.EventHandler(UpdateCart);
                tableLayoutPanel1.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void dt_cart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Do you want to reduce one unit for this item?", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        Bitmap bmp;
        private void btn_printBil_Click(object sender, EventArgs e)
        {
            int height = dt_cart.Height;
            dt_cart.Height = dt_cart.RowCount * dt_cart.RowTemplate.Height * 2;
            bmp = new Bitmap(dt_cart.Width, dt_cart.Height);
            dt_cart.DrawToBitmap(bmp, new Rectangle(0, 0, dt_cart.Width, dt_cart.Height));
            dt_cart.Height = height;
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            int index = cb_listStore.SelectedIndex;
            Store temp = listStore[index];
            dh.UpdateDatagrideview(temp.ID);
        }

        // make a payment for visitor
        private void button3_Click(object sender, EventArgs e)
        {
            
            string item_name="";
            int item_quantity = 0;
           // int indexOfColumn = 0;
            foreach (DataGridViewRow row in dt_cart.Rows) {
                 item_name = row.Cells[1].Value.ToString();
                 item_quantity = Convert.ToInt32(row.Cells[2].Value);
                decimal price = Convert.ToDecimal(row.Cells[3].Value);

            }
            int v_id = dh.GetVisitorIdByRFID(lb_rfid_purchase.Text);
            int i_id = dh.GetIdByItemName(item_name);
            dh.InsertNewRecordForPurchaseItem(v_id,i_id,item_quantity,DateTime.Now);
        }

        private void btn_printTable_Click(object sender, EventArgs e)
        {
            if (cb_listStore.Text == "Choose a store")
            {
                MessageBox.Show("There's nothing to print", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int height = dataGridView_StoreInfo.Height;
                dataGridView_StoreInfo.Height = dataGridView_StoreInfo.RowCount * dataGridView_StoreInfo.RowTemplate.Height * 10;
                bmp = new Bitmap(dataGridView_StoreInfo.Width, dataGridView_StoreInfo.Height);
                dataGridView_StoreInfo.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView_StoreInfo.Width, dataGridView_StoreInfo.Height));
                dataGridView_StoreInfo.Height = height;
                printPreviewDialog1.ShowDialog();
            }
        }
    }
}
