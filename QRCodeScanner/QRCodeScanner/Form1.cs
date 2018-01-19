using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;

namespace QRCodeScanner {
    public partial class Form1 : Form {

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice VideoSource;
        DataHelper dh = new DataHelper();
        private RFID myRFIDReader;
        public Form1() {
            InitializeComponent();
            timer2.Start();
            ClearFields();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Open();
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
            }
            catch (PhidgetException) { MessageBox.Show("Can not find RFID reader!"); }
        }
        private void Form1_Load(object sender, EventArgs e) {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices) {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            VideoSource = new VideoCaptureDevice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (VideoSource.IsRunning == true) {
                VideoSource.Stop();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e) {
            VideoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            VideoSource.NewFrame += VideoSource_NewFrame;
            VideoSource.Start();
            comboBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (VideoSource.IsRunning) {
                VideoSource.Stop();
                pictureBox1.Image = null;
            }
            comboBox1.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            timer1.Start();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e) {
            timer1.Stop();
            button4.Enabled = false;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            BarcodeReader reader = new BarcodeReader();
            try
            {
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                string decoded = result.ToString().Trim();
                using (MySqlConnection connection = new MySqlConnection("server=studmysql01.fhict.local;" +
                        "database=dbi361552;" +
                        "user id=dbi361552;" +
                        "password=p@55w0rdn0tf0und;" +
                        "connect timeout=3;"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM visitor WHERE ticket_id = @ticket_id;", connection))
                    {
                        command.Parameters.AddWithValue("@ticket_id", decoded);
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                lb_ticketID.Text = decoded;
                                lb_fname.Text = dataReader["first_name"].ToString();
                                lb_lname.Text = dataReader["last_name"].ToString();
                                //converts ticket_id string into QRcode
                                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                                pb_qrCode.Image = qrcode.Draw(decoded, 50);
                            }
                            else
                            {
                                pb_qrCode.Image = Properties.Resources.Cross;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearFields();
            pb_qrCode.Image = null;
        }

        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            if(lb_fname.Text != "" && lb_lname.Text != "" && pb_qrCode.Image != null)
            {
                if(dh.CheckRFID(e.Tag) == true)
                {
                    lb_RFID.Text = e.Tag;
                }
                else
                {
                    MessageBox.Show("RFID is already in use!");
                }
            }
            else
            {
                MessageBox.Show("Scan ticket first!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(lb_fname.Text != "" && lb_lname.Text != "" && pb_qrCode.Image != null && lb_RFID.Text != "" && lb_ticketID.Text != "")
            {
                dh.InsertRFID(lb_RFID.Text);
                dh.AssignRFID(lb_ticketID.Text, lb_RFID.Text);
                ClearFields();
            }
            else
            {
                if(lb_RFID.Text == "")
                {
                    MessageBox.Show("Scan a RFID bracelet first!");
                }
                else
                {
                    MessageBox.Show("Scan ticket first!");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lb_currentTime.Text = dateTime.ToString();
        }

        private void ClearFields()
        {
            lb_fname.Text = "";
            lb_lname.Text = "";
            lb_ticketID.Text = "";
            lb_RFID.Text = "";
            pb_qrCode.Image = null;
        }
    }
}
