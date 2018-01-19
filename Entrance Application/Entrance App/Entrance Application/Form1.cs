using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Entrance_Application {
    public partial class Form1 : Form {
        Order o = new Order();
        DataHelper dh = new DataHelper();
        PrintDocument pdoc;
        public Form1() {
            InitializeComponent();
            //full screen
            this.WindowState = FormWindowState.Maximized;
            lb_spotFull.Text = "";
            UpdateFields();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }


        private void button3_Click(object sender, EventArgs e) //Proceed to Payment
        {
            DateTime minDate = new DateTime(2000, 1, 20);
            bool campingSpot = false;

            if(rb_spotTrue.Checked == true)
            {
                campingSpot = true;
            }
    
            if (dt_dob.Value < minDate && tb_fname.Text != "" && tb_lname.Text != "") //if email is valid you can proceed your order
            {
                o.AddTicket();

                if(rb_spotTrue.Checked == true)
                {
                    o.AddPersontoCamping();
                }

                Visitors vis = new Visitors(tb_fname.Text, tb_lname.Text, dt_dob.Value, null, null, null, null, campingSpot);
                o.orderList.Add(vis);
                lb_Overview.Items.Add(vis.AsString());
                UpdateFields();

                MessageBox.Show("Your total will be: €" + Convert.ToString(o.GetTotalPrice()));
                //decimal price = Convert.ToDecimal(Convert.ToString(lb_campingPrice.Text).Replace("€", String.Empty)) + Convert.ToDecimal(Convert.ToString(lb_reservationPrice.Text).Replace("€", String.Empty));
                //dh.AddVisitors(o.orderList, price);

                List<string> listTicket = dh.GetAvailableTickets();
                List<string> listRfid = dh.GetAvailableRFID();
                foreach (Visitors v in o.orderList)
                {
                    if (v.CampingSpot == true) //People with camping spots
                    {
                        DateTime bd = v.Birthday;
                        string s = bd.ToString("yyyy-MM-dd");
                        dh.AddVisitorWithCamping(v.FirstName, v.LastName, s, listTicket[0], listRfid[0]);
                        dh.UpdateTicketTable(listTicket[0]);
                        listTicket.RemoveAt(0);
                        listRfid.RemoveAt(0);
                    }
                    else
                    {// people who dont book camping
                        DateTime bd = v.Birthday;
                        string s = bd.ToString("yyyy-MM-dd");
                        dh.AddVisitorWithCamping(v.FirstName, v.LastName, s, listTicket[0], listRfid[0]);
                        dh.UpdateTicketTable(listTicket[0]);
                        listTicket.RemoveAt(0);
                        listRfid.RemoveAt(0);
                    }
                }

                if (lb_campingQuan.Text != "0")
                {
                    decimal price = Convert.ToDecimal(Convert.ToString(lb_campingPrice.Text).Replace("€", String.Empty)) + Convert.ToDecimal(Convert.ToString(lb_reservationPrice.Text).Replace("€", String.Empty));
                    dh.UpdateCampingSpotTable(dh.FindCampingSpot(), price);
                }

                Print(); //prints receipt
                Form2 paymentScreen = new Form2();
                paymentScreen.Show();
                this.Hide();

            }
            else if(tb_fname.Text == "" && tb_lname.Text == "" && o.orderList.Count > 0)
            {
                UpdateFields();
                MessageBox.Show("Your total will be: €" + Convert.ToString(o.GetTotalPrice()));

                List<string> listTicket = dh.GetAvailableTickets();
                List<string> listRfid = dh.GetAvailableRFID();            
                foreach (Visitors v in o.orderList)
                {
                    if (v.CampingSpot == true) //People with camping spots
                    {
                        DateTime bd = v.Birthday;
                        string s = bd.ToString("yyyy-MM-dd");
                        dh.AddVisitorWithCamping(v.FirstName, v.LastName, s, listTicket[0], listRfid[0]);
                        dh.UpdateTicketTable(listTicket[0]);
                        listTicket.RemoveAt(0);
                        listRfid.RemoveAt(0);
                    }
                    else
                    {// people who dont book camping
                        DateTime bd = v.Birthday;
                        string s = bd.ToString("yyyy-MM-dd");
                        dh.AddVisitorNoCamping(v.FirstName, v.LastName, s, listTicket[0], listRfid[0]);
                        dh.UpdateTicketTable(listTicket[0]);
                        listTicket.RemoveAt(0);
                        listRfid.RemoveAt(0);
                    }
                }

                if(lb_campingQuan.Text != "0")
                {
                    decimal price = Convert.ToDecimal(Convert.ToString(lb_campingPrice.Text).Replace("€", String.Empty)) + Convert.ToDecimal(Convert.ToString(lb_reservationPrice.Text).Replace("€", String.Empty));
                    dh.UpdateCampingSpotTable(dh.FindCampingSpot(), price);
                }

                Print();
                Form2 paymentScreen = new Form2();
                paymentScreen.Show();
                this.Hide();
            }
            else
            {
                if(tb_fname.Text == "" && tb_lname.Text == "")
                {
                    MessageBox.Show("Please make sure all fields are filled in!");
                }
                else if (dt_dob.Value > minDate)
                {
                    MessageBox.Show("You must be 18+ to attend the festival!");
                }
              
                else if (o.orderList.Count == 0)
                {
                    MessageBox.Show("Add people to order first!");
                }
                else
                {
                    MessageBox.Show("Please check if everything is valid!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //Add another person
        {
            DateTime minDate = new DateTime(2000, 1, 20);
            bool campingSpot = false;

            if(rb_spotTrue.Checked == true)
            {
                campingSpot = true;
            }

            if( dt_dob.Value < minDate && tb_fname.Text != "" && tb_lname.Text != "" && lb_Overview.Items.Count < 6) //if email is valid and the person is over 18 you can proceed your order
            {
                o.AddTicket();

                Visitors vis = new Visitors(tb_fname.Text, tb_lname.Text, dt_dob.Value, null, null, null, null, campingSpot);
                o.orderList.Add(vis);
                lb_Overview.Items.Add(vis.AsString());

                if(campingSpot == true)
                {
                    o.AddPersontoCamping();
                    rb_spotTrue.Checked = false;
                }

                ClearFields();
                UpdateFields();
            }
            else
            {
              
                if(dt_dob.Value > minDate)
                {
                    MessageBox.Show("You must be 18+ to attend the festival!");
                }
                else if(lb_Overview.Items.Count >= 6)
                {
                    MessageBox.Show("Only 6 people per order!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please make sure all fields are filled in!");
                }
            }
        }

        public void ClearFields()
        {
            //clears all fields for next order
            tb_fname.Clear();
            tb_lname.Clear();
            dt_dob.ResetText();
           
            rb_spotFalse.Checked = true;
        }

        public void UpdateFields()
        {
            //ticket costs
            lb_ticketQuan.Text = Convert.ToString(o.TicketQuantity);
            lb_ticketPrice.Text = o.GetTicketTotal();
            //camping costs
            lb_campingQuan.Text = Convert.ToString(o.CampingSpotQuantity);
            lb_campingPrice.Text = o.GetCampingTotal();
            //reservation costs
            lb_reservationQuan.Text = Convert.ToString(o.ReservationQuantity);
            lb_reservationPrice.Text = o.GetReservationTotal();
            //total price
            lb_totalPrice.Text = "€" + Convert.ToString(o.GetTotalPrice());

            //checks if camping spot is full
            if(o.CampingSpotFull == true)
            {
                lb_spotFull.Text = "FULL";
            }
            else
            {
                lb_spotFull.Text = "";
            }

            //checks if limit is reached (6 ppl per order)
            if(o.orderList.Count >= 6)
            {
                lb_limit.Text = "LIMIT";
            }
            else
            {
                lb_limit.Text = "";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = lb_Overview.SelectedIndex;
            lb_Overview.ClearSelected();
            Visitors vis = o.orderList[selectedIndex] as Visitors;

            o.RemoveTicket();
            if (vis.CampingSpot == true)
            {
                o.removePersonFromCamping();
            }

            o.orderList.RemoveAt(selectedIndex);
            lb_Overview.Items.RemoveAt(selectedIndex);
            
            UpdateFields();
            ClearFields();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lb_Overview.SelectedItems.Count > 0)
            {
                Visitors v = o.orderList[lb_Overview.SelectedIndex] as Visitors;
                if (btn_addPerson.Enabled == false && btn_proceed.Enabled == false && btn_Remove.Enabled == false)
                {
                    v.FirstName = tb_fname.Text;
                    v.LastName = tb_lname.Text;
                    v.Birthday = dt_dob.Value;
                   

                    if (v.CampingSpot == true && rb_spotFalse.Checked == true)
                    {
                        o.removePersonFromCamping();
                    }
                    else if (v.CampingSpot == false && rb_spotTrue.Checked == true)
                    {
                        o.AddPersontoCamping();
                    }

                    if (rb_spotTrue.Checked == true)
                    {
                        v.CampingSpot = true;
                    }
                    else
                    {
                        v.CampingSpot = false;
                    }

                    btn_addPerson.Enabled = true;
                    btn_proceed.Enabled = true;
                    btn_Remove.Enabled = true;

                    int selectedIndex = lb_Overview.SelectedIndex;
                    lb_Overview.ClearSelected();
                    lb_Overview.Items.RemoveAt(selectedIndex);
                    lb_Overview.Items.Insert(selectedIndex, v.AsString());

                    UpdateFields();
                    ClearFields();
                }
                else
                {
                    btn_addPerson.Enabled = false;
                    btn_proceed.Enabled = false;
                    btn_Remove.Enabled = false;

                    tb_fname.Text = v.FirstName;
                    tb_lname.Text = v.LastName;
                    dt_dob.Value = v.Birthday;
                   
                    if(v.CampingSpot == true)
                    {
                        rb_spotTrue.Checked = true;
                    }
                    else
                    {
                        rb_spotFalse.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a person first!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lb_currentTime.Text = dateTime.ToString();
        }

        public void Print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);

            PaperSize psize = new PaperSize("Custom", 100, 100);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 50;

            pdoc.DefaultPageSettings.PaperSize.Width = 50;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                pp.Width = 50;
                pp.Height = 50;
                pp.PerformAutoScale();
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;

            graphics.DrawString("Welcome to Sportify Festival", new Font("Courier New", 16),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Time of purchase: " + DateTime.Now, new Font("Courier New", 10),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            String underLine = "------------------------------------------";

            graphics.DrawString(underLine,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(lb_ticketQuan.Text + "x person in camping",
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            graphics.DrawString("-- " + lb_ticketPrice.Text,
                     new Font("Courier New", 13),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            if(lb_campingQuan.Text != "0")
            {
                graphics.DrawString(lb_campingQuan.Text + "x person in camping spot",
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;

                graphics.DrawString("-- " + lb_campingPrice.Text, new Font("Courier New", 13),
                     new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;

                graphics.DrawString(lb_reservationQuan.Text + "x reservation costs",
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;

                graphics.DrawString("-- " + lb_reservationPrice.Text, new Font("Courier New", 13),
                     new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;
            }

            graphics.DrawString(underLine, new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            graphics.DrawString("Total: " + lb_totalPrice.Text, new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString(underLine, new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            graphics.DrawString("Enjoy your time at Sportify!", new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
        }
    }
}

