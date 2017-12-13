using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Event_Overview_Application
{


    class DataHelper : IData
    {
        //fields
        private string connectionInfo;
        private MySqlConnection connection;
        Visitors v;

        //constructor
        public DataHelper()
        {
            connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi361552;" +
                               "user id=dbi361552;" +
                               "password=p@55w0rdn0tf0und;" +
                               "connect timeout=3;";

            connection = new MySqlConnection(connectionInfo);
        }
        //*******************************************METHOD******************************//
        /// <summary>
        /// Override methods from IData Interface
        /// </summary>

        // Get Total Visitors 
        public int getTotalVisitors()
        {
            int total = 0;
            string sql = string.Format("select count(*) from visitor");
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                // Int32 count = (Int32)command.ExecuteScalar();
                total = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return total;
        }
        //Get Total Visitors At the event
        public int getTotalVisitorsAtEvent()
        {
            int total = 0;
            MySqlCommand command = new MySqlCommand(string.Format("select count(distinct visitor_id) from checking_history where checking_action='IN'"), connection);
            try
            {
                connection.Open();

                total = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                connection.Close();
            }
            return total;
        }
        //Get Visitor History
        public List<string> getVistorHistory(int id)
        {
            //get DateTIme //todo
            List<string> list = new List<string>();
            string sql = string.Format("SELECT checking_action, checking_location, transaction_action, transaction_amount FROM checking_history c left outer join transaction t on c.visitor_id=t.visitor_id WHERE t.visitor_id={0}", id);
         //   string sql1 = string.Format("SELECT transaction_action, transaction_amount FROM transaction WHERE visitor_id={0}", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
         //   MySqlCommand command1 = new MySqlCommand(sql1, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
              //  MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader.Read())
                {
                    string history = (string)reader["checking_action"] + " " + (string)reader["checking_location"] + " " + (string)reader["transaction_action"] + " " + reader["transaction_amount"].ToString();
                    list.Add(history);
                }
               
            }
            catch (MySqlException e) { MessageBox.Show("tHAO"); }
            finally { connection.Close(); }
            return list;
        }

        //Get camping spot by id
        public Camping getSpotbyId(int id)
        {
            //todo
            return null;
        }
        //Get Visitor by id
        public Visitors GetVisitorById(int id) {
            string sql = string.Format("SELECT * FROM visitor  where visitor_id='{0}'", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string fname = (string)(reader["first_name"]);
                    string ln = (string)(reader["last_name"]);
                    //   string bd= (string)(reader["birthday"]);
                    string phone = null;
                    string email = (string)(reader["email"]);
                    string ticket = (string)(reader["ticket_id"]);
                    int spot = Convert.ToInt32(reader["spot_id"]);
                    string rrfid = (string)(reader["rfid"]);
                    v = new Visitors(id, fname, ln, phone, email, ticket, spot, rrfid);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                    connection.Close();
            }
            return v;
        }

        //Get List of Visitors from database
        public List<Visitors> getListOfVisitors()
        {
            List<Visitors> listVisitors = new List<Visitors>();
            MySqlCommand command = new MySqlCommand("SELECT visitor_id,ticket_id,rfid,IFNULL(spot_id,0),first_name,last_name,birthday,email FROM visitor", connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["visitor_id"]);
                    string fname = (string)(reader["first_name"]);
                    string ln = (string)(reader["last_name"]);
                    // v.Birthday = (DateTime)(reader["birthday"]);
                    string phone = null;
                    string email = (string)(reader["email"]);
                    string ticket = (string)(reader["ticket_id"]);
                    // int spot = Convert.ToInt32(reader["spot_id"]);
                    int spot = 0;
                    string rfid = (string)(reader["rfid"]);
                    v = new Visitors(id, fname, ln, phone, email, ticket, spot, rfid);
                    listVisitors.Add(v);
                }
            }

            catch (MySqlException e) { MessageBox.Show(e.Message); }

            finally
            {
                connection.Close();
            }
            return listVisitors;

        }

        //Get Item by id
        public Item getItemById(int id)
        {
            Item i = null;
            string sql = string.Format("SELECT * FROM item WHERE item_id={0}", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try {

             //   connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int item_id = Convert.ToInt32(reader["item_id"]);
                    string name = (string)(reader["item_name"]);
                    string category = (string)(reader["item_category"]);
                    // v.Birthday = (DateTime)(reader["birthday"]);
                    double price = Convert.ToDouble(reader["item_price"]);
                    int quantity = Convert.ToInt32(reader["item_quantity"]);
                    int store_id = Convert.ToInt32(reader["store_id"]);
                   
                    i = new Item(id, name, category, price, quantity, store_id);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }

            finally
            {
                connection.Close();
            }
            return i;
        }

        //Get Store by Name
        public int getStoreIdByName(string name)
        {
            int id = 0;
            string sql = string.Format("SELECT store_id FROM store WHERE store_name='{0}'", name);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        //Get Visitor by RFID 
        public Visitors getVisitorByRfid(string rfid)
        {
            //Check is this rfid code exist in database or not??????????????????????????????????
            string sql = string.Format("SELECT * FROM visitor  where rfid='{0}'", rfid);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["visitor_id"]);
                    string fname = (string)(reader["first_name"]);
                    string ln = (string)(reader["last_name"]);
                    //   string bd= (string)(reader["birthday"]);
                    string phone = null;
                    string email = (string)(reader["email"]);
                    string ticket = (string)(reader["ticket_id"]);
                    int spot = Convert.ToInt32(reader["spot_id"]);
                    string rrfid = (string)(reader["rfid"]);
                    //  v = new Visitors(Convert.ToString(reader["first_name"]), Convert.ToString(reader["last_name"]), Convert.ToDateTime(reader["birthday"]), Convert.ToString(reader["phone"]), Convert.ToString(reader["email"]), Convert.ToString(reader["ticket_id"]), Convert.ToString(reader["spot_id"]), Convert.ToString(reader["rfid"]));
                    v = new Visitors(id, fname, ln, phone, email, ticket, spot, rrfid);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return v;
        }

        //////22/11

        //Get total balance
        public double GetTotalBalance()
        {
            double total_balance = 0;
            string sql = "SELECT sum(balance) FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                total_balance = Convert.ToDouble(command.ExecuteScalar());

            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return total_balance;
        }

        //get total spent money
        public double GetTotalMoneySpent()
        {
            double total_money_spent = 0;
            string sql = "SELECT sum(transaction_amount) FROM transaction";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                total_money_spent = Convert.ToDouble(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return total_money_spent;
        }

        //Get List of Camping Spot id
        public List<Camping> GetListOfSpotId()
        {
            List<Camping> list = new List<Camping>();
            string sql = "SELECT * FROM camping_spot";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string location = Convert.ToString(reader[1]);
                    Camping temp = new Camping(id, location);
                    list.Add(temp);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return list;
        }
        //Get List of Visitors reserved Camping spot
        public List<Visitors> GetVisitorsReservedCampingSpot(int id)
        {
            List<Visitors> list = new List<Visitors>();
            Visitors v;
            string sql = string.Format("SELECT visitor_id,first_name,last_name,email,phone,ticket_id,rfid FROM visitor where spot_id={0}", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int v_id = Convert.ToInt32(reader["visitor_id"]);
                    string fname = (string)(reader["first_name"]);
                    string ln = (string)(reader["last_name"]);
                    //   string bd= (string)(reader["birthday"]);
                    string phone = null;
                    string email = (string)(reader["email"]);
                    string ticket = (string)(reader["ticket_id"]);
                    string rrfid = (string)(reader["rfid"]);
                    //  v = new Visitors(Convert.ToString(reader["first_name"]), Convert.ToString(reader["last_name"]), Convert.ToDateTime(reader["birthday"]), Convert.ToString(reader["phone"]), Convert.ToString(reader["email"]), Convert.ToString(reader["ticket_id"]), Convert.ToString(reader["spot_id"]), Convert.ToString(reader["rfid"]));
                    v = new Visitors(v_id, fname, ln, phone, email, ticket, id, rrfid);
                    list.Add(v);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return list;
        }

        //Get All Camping spot Has been Reserved
        public List<Camping> GetReservedSpot()
        {
            List<Camping> list = new List<Camping>();
            Camping c;
            string sql = "SELECT c.spot_id, c.location  FROM camping_spot c join visitor v on c.spot_id = v.spot_id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string location = (string)(reader[1]);
                    c = new Camping(id, location);
                    list.Add(c);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return list;
        }
        //Check if a spot has been reserved or not
        public bool CheckReservedSpot(int id)
        {
            List<Camping> list = this.GetReservedSpot();
            foreach (Camping c in list)
            {
                if (c.Camping_id == id)
                    return true;
            }
            return false;
        }
        //Total booked spots
        public int TotalBookedSpots()
        {
            int result = 0;
            string sql = "SELECT count(distinct spot_id) FROM visitor";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return result;
        }
        //Total Free spots
        public int TotalFreeSpots()
        {
            int result = 0;
            string sql = "SELECT count(distinct spot_id) FROM camping_spot WHERE spot_id NOT IN (SELECT spot_id FROM visitor)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return result;
        }
        //Total Visitor Check in//TODO

        //Get All Store //SAME with Store app
        public List<Store> getListOfStore()
        {
            List<Store> list = new List<Store>();
            string sql = "SELECT * FROM store";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["store_id"]);
                    string name = Convert.ToString(reader["store_name"]);
                    Store s = new Store(id, name);
                    list.Add(s);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return list;
        }
        //Get All Item Name
        public List<Item> GetListOfItem()
        {
            List<Item> list = new List<Item>();
            Item i;
            string sql = "SELECT * from item";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["item_id"]);
                    string name = (string)(reader["item_name"]);
                    int store_id = Convert.ToInt32(reader["store_id"]);
                    string category = (string)reader["item_category"];
                    double price = Convert.ToDouble(reader["item_price"]);
                    //  int quantity = Convert.ToInt32()
                    i = new Item(id, name, category, price, 0, store_id);
                    list.Add(i);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return list;
        }
        ////3-12
       // Get total profit
        public decimal GetProfitByStoreId(int id)
        {
            decimal profit = 0;
            string sql = string.Format("SELECT IFNULL(deposit_price,0) FROM item WHERE store_id ={0}", id);
            MySqlCommand command;
            command= new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                decimal deposit = Convert.ToDecimal(command.ExecuteScalar());
                if (deposit == 0)
                { //purchase items
                    string sql1 = string.Format("SELECT IFNULL( sum(p.purchase_quantity * i.item_price),0) from item i join purchase p on i.item_id =p.item_id where i.store_id ={0}",id);
                    command = new MySqlCommand(sql1, connection);
                    profit =Convert.ToDecimal( command.ExecuteScalar());

                }
                else//rental items
                {
                    string sql2 = string.Format("SELECT IFNULL(sum(i.item_price),0) FROM item i join rental r on i.item_id = r.item_id where i.store_id={0}",id);
                    command = new MySqlCommand(sql2, connection);
                    profit = Convert.ToDecimal(command.ExecuteScalar());
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return profit;

        }
        //get list of Profit
        public List<decimal> GetListProfit() {
            List<Decimal> listProfit = new List<decimal>();
            List<Store> listStore = this.getListOfStore();
            foreach (Store s in listStore) {
                listProfit.Add(GetProfitByStoreId(s.Id));
            }
            return listProfit;
        }
        //Get total profit of the whole event
        public decimal TotalProfit() {
            decimal total = 0;
            foreach (decimal d in this.GetListProfit()) {
                total += d;
            }
            return total;
        }
        //Get the best shop based on Profit
        public Store TheBestShop() {
            Store s = null;
            decimal max = 0;
            int  i1=0;
            List<decimal> listprofit = this.GetListProfit();
            for ( int i = 0; i < listprofit.Count; i++) {
                if (listprofit[i] > max)
                {
                    max = listprofit[i];
                    i1 = i;
                }
            }
            List<Store> listStore = this.getListOfStore();
            s = listStore[i1];
            return s;
        }
        //Get the best selling item
        public Item TheBestSelling() {
            Item i = new Item(0,"","",0,0,0);
            string sql = "select p.item_id from purchase p having sum(p.purchase_quantity) > any(select sum(purchase_quantity) from purchase GROUP by item_id)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try {
                connection.Open();
                int id =Convert.ToInt32( command.ExecuteScalar());
                i = this.getItemById(id);
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return i;
        }
        //Get total item per store
        public int GetTotalItemPerStore(int id) {
            int total = 0;
            string sql = string.Format("SELECT count(item_id) FROM item WHERE store_id={0}", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try {
                connection.Open();
                total =Convert.ToInt32( command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally { connection.Close(); }
            return total;
        }
        
    }
    
}
