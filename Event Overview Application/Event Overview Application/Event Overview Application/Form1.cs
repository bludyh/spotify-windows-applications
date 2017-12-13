using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet.Charts;

namespace Event_Overview_Application {
    public partial class Form1 : Form
    {

        private DataHelper dh;

        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            LoadVisitorsToCbx(); //Load Visitors from db to combobox
            LoadSpotIdToCbx();   //Load camping spot from db to combobox
            LoadStoreCombobox(); //  ForShopOverviewCombobox();
            lb_visitorFromSuggestion.Visible = false; //invisible the suggesting listbox for typing names
            BindNames();//Suggestions when typing Name for Visitor overview

            btn_visitorOverview.BackgroundImageLayout = ImageLayout.Stretch;
            btn_shopoverview.BackgroundImageLayout = ImageLayout.Stretch;

            panel_shops.Visible=panel_visitors.Visible=panel_spots.Visible = false;
            //set the font for labels

            btn_lookUp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lookUp.TextAlign = ContentAlignment.MiddleRight;
            btn_lookUp.BackgroundImageLayout = ImageLayout.Stretch;

            //set full screen
            this.WindowState = FormWindowState.Maximized;
            
            //Set icon for button
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Show Info from selected camping spot id
        private void button4_Click(object sender, EventArgs e)
        {
            lbx_visitorsReservedSpot.Items.Clear();
            int id = ((Camping)cbx_spotId.SelectedItem).Camping_id;
            if (dh.CheckReservedSpot(id))
            {
                List<Visitors> list = dh.GetVisitorsReservedCampingSpot(id);
                foreach (Visitors v in list)
                {
                    lbx_visitorsReservedSpot.Items.Add(v);
                }
            }
            else { lbx_visitorsReservedSpot.Items.Add("NO ONE HAS RESERVED THIS SPOT YET"); }
        }

      

        //Clear button
        private void button3_Click(object sender, EventArgs e)
        {
            cbx_spotId.Text = "";
            lbx_visitorsReservedSpot.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        //******************************EXTRA METHOD***************************//

        //Load Visitors from DB to combobox
        public void LoadVisitorsToCbx()
        {
            List<Visitors> list = dh.getListOfVisitors();
            foreach (Visitors v in list)
            {
               // cb_visitorID.Items.Add(v.ToString());
            }
        }
        //Load Camping spot Id from DB to combobox
        public void LoadSpotIdToCbx()
        {
            List<Camping> list = dh.GetListOfSpotId();
            foreach (Camping c in list)
            {
                cbx_spotId.Items.Add(c);
            }
        }
     
        //Shop overview combobox
       
        ///3-12 TEST
        ///List suggestions when typing text in the textbox
        private void BindNames() {
            List<string> listNames = new List<string>();
            foreach (Visitors v in dh.getListOfVisitors()) {
                listNames.Add(v.FirstName + "," + v.LastName+"-" +v.Id);
            }
            var source = new AutoCompleteStringCollection();
            txt_Names.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            source.AddRange(listNames.ToArray());
            txt_Names.AutoCompleteCustomSource = source;
            txt_Names.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Names.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txt_Names_TextChanged(object sender, EventArgs e)
        {
            lb_visitorFromSuggestion.Items.Clear();
            if (txt_Names.Text.Length == 0) {
                lb_visitorFromSuggestion.Visible = false;
                return;
            }
            foreach (string s in txt_Names.AutoCompleteCustomSource) {
                if (s.Contains(txt_Names.Text)) {
                    lb_visitorFromSuggestion.Items.Add(s);
                    lb_visitorFromSuggestion.Visible = true;
                }
            }
        }

        private void lb_visitorFromSuggestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Names.Text = lb_visitorFromSuggestion.Items[lb_visitorFromSuggestion.SelectedIndex].ToString();
            lb_visitorFromSuggestion.Visible = false;
        }

        private void btn_lookUp_Click(object sender, EventArgs e)

        {
            lb_visitorHistory.Items.Clear();
            if (this.GetIdFromNameString(txt_Names.Text) == -1) {
                MessageBox.Show("No visitor to search");
            }
            else
            {
                Visitors v = dh.GetVisitorById(this.GetIdFromNameString(txt_Names.Text));
                lb_fname.Text = v.FirstName;
                lb_lname.Text = v.LastName;
                //lb_bd.Text = v.Birthday.ToString();
                lb_email.Text = v.Email;
                lb_phone.Text = v.Phone;
                lb_ticketId.Text = v.Ticket_id.ToString();
                lb_spotID.Text = v.Spot_id.ToString();
                lb_rfid.Text = v.Rfid;
                List<string> history = dh.getVistorHistory(v.Id);
                foreach (string str in history) {
                    lb_visitorHistory.Items.Add(str);
                }
            }

        }
        //get id from Name string 
        private int GetIdFromNameString(string str) {
            if (str == "")
            {
                return -1;
            }
            else
            {
                string[] temp = str.Split('-');
                return Convert.ToInt32(temp[temp.Length - 1]);
            }
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Names.Text = lb_fname.Text = lb_lname.Text = lb_email.Text = lb_bd.Text = lb_phone.Text = lb_rfid.Text = lb_spotID.Text = lb_ticketId.Text = "";
            lb_visitorHistory.Items.Clear();
        }

        private void btn_visitorOverview_Click(object sender, EventArgs e)
        {
            panel_shops.Visible = false;
            panel_spots.Visible = panel_visitors.Visible = true;
            lb_totalVisitor.Text = dh.getTotalVisitors().ToString();
            lb_totalBalancee.Text = dh.GetTotalBalance().ToString();
            lb_totalvisitorsatEvent.Text = dh.getTotalVisitorsAtEvent().ToString();
            lb_spentMoney.Text = dh.GetTotalMoneySpent().ToString();
            lb_bookedspot.Text = dh.TotalBookedSpots().ToString();
            lb_freeSpot.Text = dh.TotalFreeSpots().ToString();
        }
        private void btn_shopoverview_Click(object sender, EventArgs e)
        {
            panel_shops.Visible = true;
            panel_spots.Visible = panel_visitors.Visible = false;
            int id;
            ///Get the data for the charts
            ///
            //The profits chart
            id = dh.getStoreIdByName("NIKE");
            this.chart_shops.Series["Profit"].Points.AddXY("NIKE",dh.GetProfitByStoreId(id));
            id = dh.getStoreIdByName("ELECTRONICS");
            this.chart_shops.Series["Profit"].Points.AddXY("ELECTRONICS", dh.GetProfitByStoreId(id));
            id = dh.getStoreIdByName("TONYS WOK");
            this.chart_shops.Series["Profit"].Points.AddXY("TONY'S WOK", dh.GetProfitByStoreId(id));
            //the pie chart
            this.piechart.Series["Profit1"].Points.AddXY(dh.TheBestShop().Name, dh.GetProfitByStoreId(dh.TheBestShop().Id));
            this.piechart.Series["Profit1"].Points.AddXY("Total Profit", dh.TotalProfit());

            //The best shop
            lb_BestShop.Text = dh.TheBestShop().Name;

            //The best selling item
            lb_bestSelling.Text = dh.TheBestSelling().Item_name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbx_spotId.Text == "") { MessageBox.Show("No spot selected!"); }
            else
            {
                lbx_visitorsReservedSpot.Items.Clear();
                int id = ((Camping)cbx_spotId.SelectedItem).Camping_id;
                if (dh.CheckReservedSpot(id))
                {
                    List<Visitors> list = dh.GetVisitorsReservedCampingSpot(id);
                    foreach (Visitors v in list)
                    {
                        lbx_visitorsReservedSpot.Items.Add(v);
                    }
                }
                else { lbx_visitorsReservedSpot.Items.Add("NO ONE HAS RESERVED THIS SPOT YET"); }
            }
        }

        private void chart_shops_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportToExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //add data 
           // xlWorkSheet.Cells[1, 1] = "";
            xlWorkSheet.Cells[1, 2] = "Profit";

            int id;
            id = dh.getStoreIdByName("NIKE");
            xlWorkSheet.Cells[2, 1] = "NIKE";
            xlWorkSheet.Cells[2, 2] = dh.GetProfitByStoreId(id).ToString();
           

            id = dh.getStoreIdByName("ELECTRONICS");
            xlWorkSheet.Cells[3, 1] = "ELECTRONICS";
            xlWorkSheet.Cells[3, 2] = dh.GetProfitByStoreId(id).ToString();
           

            id = dh.getStoreIdByName("TONYS WOK");
            xlWorkSheet.Cells[4, 1] = "TONYS WOK";
            xlWorkSheet.Cells[4, 2] =dh.GetProfitByStoreId(id).ToString() ;
           
           

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "d5");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            //export chart as picture file
            chartPage.Export(@"C:\Users\Thao Nguyen\Desktop\excel_chart_export.bmp", "BMP", misValue);

            xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp-Excel.xls");
        }
    private void releaseObject(object obj)
    {
        try
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            obj = null;
        }
        catch (Exception ex)
        {
            obj = null;
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
        }
        finally
        {
            GC.Collect();
        }
    }
        //Load combobox for store
        private void LoadStoreCombobox() {
            cbx_storeList.Items.Clear();
            List<Store> listStore = new List<Store>();
            listStore = dh.getListOfStore();
            foreach (Store s in listStore)
            {
                cbx_storeList.Items.Add(s);
            }
        }
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (cbx_storeList.Text == "")
            {
                MessageBox.Show("There is no store to show", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lb_profit.Text = dh.GetProfitByStoreId(((Store)cbx_storeList.SelectedItem).Id).ToString();
                lb_unit.Text = dh.GetTotalItemPerStore(((Store)cbx_storeList.SelectedItem).Id).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbx_spotId.Text = "";
            lbx_visitorsReservedSpot.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cbx_storeList.Text = lb_unit.Text = lb_profit.Text = "";
        }
        //5-12

    }

}
