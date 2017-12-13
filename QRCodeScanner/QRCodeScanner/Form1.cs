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
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCodeScanner {
    public partial class Form1 : Form {

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice VideoSource;
        string connectString;
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices) {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            VideoSource = new VideoCaptureDevice();
            connectString = "server=studmysql01.fhict.local;" +
                               "database=dbi361552;" +
                               "user id=dbi361552;" +
                               "password=p@55w0rdn0tf0und;" +
                               "connect timeout=3;";
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
          //  timer1.Start();
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
            listBox1.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connectString);
            //  BarcodeReader reader = new BarcodeReader();

            //Result result = reader.Decode((Bitmap)pictureBox1.Image);
            //string decoded = result.ToString().Trim();

            // Bitmap bmp = new Bitmap(pictureBox1.Image);
            //BarcodeReader reader = new BarcodeReader { AutoRotate = true };
            //Result result = reader.Decode(bmp);
            //  string decoded = reader.ToString().Trim();
            try
            {
                //MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                string decoded = result.ToString().Trim(); //decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap) );

                MessageBox.Show(decoded);
                //string sql = string.Format("Select * from ticket where ticket_id='{0}'", decoded);
                //MySqlCommand command = new MySqlCommand(sql, connection);
            
                //connection.Open();
                //MySqlDataReader sqlReader = command.ExecuteReader();
                //if (sqlReader.Read())
                //{
                //    listBox1.Items.Add("Ticket ID: " + sqlReader["ticket_id"]);
                //}
            }
            catch (Exception ex) {
                //MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }

                //using (MySqlConnection connection = new MySqlConnection(connectString)) {
                //    connection.Open();
                    
                //    using (MySqlCommand command = new MySqlCommand("SELECT * FROM visitor WHERE ticket_id =", connection)) {
                //       // command.Parameters.AddWithValue("@ticket_id", decoded);
                //        using (MySqlDataReader dataReader = command.ExecuteReader()) {
                //            if (dataReader.Read()) {
                //                listBox1.Items.Add("Ticket ID: " + dataReader["ticket_id"]);
                //                listBox1.Items.Add("First Name: " + dataReader["first_name"]);
                //                listBox1.Items.Add("Last Name: " + dataReader["last_name"]);
                //            }
                        
                    }
              

        private void button5_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
        }
    }
}
