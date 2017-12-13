using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using System.Media;

namespace Entrance_Application {
    public partial class Form1 : Form {
        private RFID myRFIDReader;
        private DataHelper dh;
        private string rfid;
        public Form1() {
            InitializeComponent();
            dh = new DataHelper();

            //set the timer tick event
            
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Interval = 10000;
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new RFIDTagEventHandler(ShowRfidTag);

                //open RFID
                try
                {
                    myRFIDReader.Open(); //this will cost some time, but this app continues . . .
                   // this.timer1.Enabled = true;
                   label45.Text=("an RFID-reader is found and opened, device-id is: " + myRFIDReader.DeviceID);
                }
                catch (PhidgetException) { label45.Text=("no RFID-reader opened???????????"); }
            }
            catch (PhidgetException) {
                MessageBox.Show("Error with RIFD reader!"); 
            }

            //full screen
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/

            //font for label
            this.lb_status.Font =lb_balaceCheckIn.Font= new Font("Arial", 20, FontStyle.Bold); //check in

            this.lb_checkOUt.Font = this.lb_balance.Font= new Font("Arial", 30, FontStyle.Bold); //check out
            
        }
        private void Form1_Load(object sender, EventArgs e) {
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //attach the rfid
        private void ShowWhoIsAttached(object sender, AttachEventArgs e) {
            try
            {
                label45.Text = string.Format("RFID device serial nr: {0} is attached", myRFIDReader.DeviceSerialNumber);

            }
            catch (Exception ex) {
               DialogResult d = MessageBox.Show("There's something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (d == DialogResult.OK) {
                    this.Refresh();
                }
            }
        }
        //detach the rfid
        private void ShowWhoIsDetached(object sender, DetachEventArgs e) {
            label45.BackColor = Color.Red;
            label45.Text = string.Format("RFID device serial nr: {0} is detached", myRFIDReader.DeviceSerialNumber);
        }
        //show the rfid tag
        private void ShowRfidTag(object sender, RFIDTagEventArgs e) {
            timer1.Start();
            string tabName = tab_entrance.SelectedTab.Name;
            if (tabName == "tab_checkIn")
            {
                lb_rfid.Text = e.Tag;
                if (dh.CheckRFID(e.Tag))//Check is it a valid rfid
                {
                    //check is it already checked in?
                    if (dh.VisitorHasCheckedBefore(e.Tag) == false)// never check in and out
                    {
                      //  Visitors v = dh.getVisitorByRfid(e.Tag);
                        dh.UpdateWhenCheckIn(e.Tag);
                        // List<string> l = dh.GetMessageForRFID(e.Tag);
                        SoundPlayer audio1 = new SoundPlayer(Entrance_Application.Properties.Resources.Sucess);
                        audio1.Play();
                        lb_status.Text = "CHECKED IN";
                        lb_balaceCheckIn.Text = dh.GetBalanceOfaVisitor(lb_cho_rfid.Text).ToString();
                    }
                    else {
                        if (dh.GetCheckedInorOut(e.Tag) == "IN") {
                            lb_status.Text = "Already IN";
                            SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Alert); 
                            audio.Play();
                        }
                        else
                        {
                            Visitors v = dh.getVisitorByRfid(e.Tag);
                            dh.UpdateWhenCheckIn(e.Tag);
                            List<string> l = dh.GetMessageForRFID(e.Tag);
                            SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Sucess);
                            audio.Play();
                            lb_status.Text = "CHECKED IN";
                            lb_balaceCheckIn.Text = dh.GetBalanceOfaVisitor(lb_cho_rfid.Text).ToString();
                        }
                    }
                }
                else {
                    lb_status.Text = "INVALID!!!!";
                    SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Alert);
                    audio.Play();
                }
            }
            if (tabName == "tab_checkOut")
            {
                lb_cho_rfid.Text = e.Tag;
                if (dh.CheckRFID(e.Tag)) //check is it a valid rfid
                {
                    //Check if visitor borrowed items??
                    int id = dh.getVisitorIdbyRFID(lb_cho_rfid.Text);
                    if (dh.CheckIfBorrowedItems(id) == true)
                    {
                        if (dh.CheckRentalStatus(lb_cho_rfid.Text) == false) //check if visitor has returned item before checking in?
                        {
                            lb_checkOUt.Text = "MUST RETURN ITEM FIRST!";
                            btn_withdrawAndCheckOut.Enabled = btn_checkOutOnly.Enabled = false;
                            SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Alert);
                            audio.Play();
                        }
                        else
                        {
                            dh.UpdateWhenCheckOut(lb_cho_rfid.Text);
                            lb_checkOUt.Text = "CHECKED OUT!";
                            lb_balance.Text = dh.GetBalanceOfaVisitor(lb_cho_rfid.Text).ToString();
                            SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Sucess);
                            audio.Play();
                            btn_withdrawAndCheckOut.Enabled = btn_checkOutOnly.Enabled = true;
                        }
                    }
                    else
                    {
                        dh.UpdateWhenCheckOut(lb_cho_rfid.Text);
                        lb_checkOUt.Text = "CHECKED OUT!";
                        lb_balance.Text = dh.GetBalanceOfaVisitor(lb_cho_rfid.Text).ToString();
                        btn_withdrawAndCheckOut.Enabled = btn_checkOutOnly.Enabled = true;
                        SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Sucess);
                        audio.Play();
                    }
                
                }
                else { MessageBox.Show("INVALID RFID");
                    SoundPlayer audio = new SoundPlayer(Entrance_Application.Properties.Resources.Alert);
                    audio.Play();
                }
                
               
            }

        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Clear button
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        //Timer tick event Handler
        private void timer1_Tick(object sender, System.EventArgs e) {
           // timer1.Interval = 3000;
            lb_rfid.Text =lb_msg.Text= "";
        }

        //Check out only button
        private void button5_Click(object sender, EventArgs e)
        {
            dh.UpdateWhenCheckOut(lb_cho_rfid.Text);
            lb_cho_rfid.Text = "";
        }

        private void btn_withdrawAndCheckOut_Click(object sender, EventArgs e)
        {
            if (dh.CheckRentalStatus(lb_cho_rfid.Text) == false)
            {
                lb_checkOUt.Text = "MUST RETURN ITEM FIRST!";

            }
            else
            {
                dh.UpdateWhenCheckOut(lb_cho_rfid.Text);
                DialogResult d= MessageBox.Show(string.Format("Withdraw: {0}, Delete this RFID ",dh.GetBalanceOfaVisitor(lb_cho_rfid.Text)),"Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                    dh.DeleteRfid(lb_cho_rfid.Text);
                else
                    MessageBox.Show("Check out without withdraw", "Infor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
