using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //added
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;

namespace Entrance_Application
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

        /// <summary>
        /// Override methods from IData Interface
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Get Total Visitors 
        public int getTotalVisitors()
        {
            int total = 0;
            connection.Open();
            string sql = string.Format("select count(distinct *) from VISITOR");
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                // Int32 count = (Int32)command.ExecuteScalar();
                total = (int)command.ExecuteScalar();
            }
            catch (FormatException) { }
            finally { connection.Close(); }
            return total;
        }
        //Get Total Visitors At the event
        public int getTotalVisitorsAtEvent()
        {
            int total = 0;
            connection.Open();
            MySqlCommand command = new MySqlCommand(string.Format("select count(distinct Visitor_ID) from CHECKING_HISTORY where Checking_Action='IN'"), connection);
            try
            {
                total = (int)command.ExecuteScalar();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return total;
        }

        //CampingOverview
        //Get List of Visitors reserved spot
        /*  public List<string> getListofVisitorsReservedSpot(int id) {
              List<string> v;
              connection.Open();
              MySqlCommand command = new MySqlCommand(string.Format("select Visitor_ID from VISITOR where Spot_ID={0}",id),connection);
              try {
                  MySqlDataReader reader = command.ExecuteReader();
                  while (reader.Read()) {

                  }
              }
          }*/


        //methods
        public Visitors getVisitorInfo(int id)
        {

            connection.Open();
            string sql = string.Format("Select First_Name,Last_Name,Birthday,Email,Phone,Ticket_ID,Spot_ID,RFID from VISITOR v join TICKET t on v.Ticket_ID=t.Ticket_ID"
                                                                                                               + "join CAMPING_SPOT c on v.Spot_ID = c.Spot_ID" +
                                                                                                                "join RFID r on v.RFID = r.RFID"
                                                                                                                + "where v.Visitor_ID ={0}", id);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try

            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    v = new Visitors(Convert.ToString(reader["First_Name"]), Convert.ToString(reader["Last_Name"]), Convert.ToDateTime(reader["Birthday"]), Convert.ToString(reader["Phone"]), Convert.ToString(reader["Email"]), Convert.ToString(reader["Ticket_ID"]), Convert.ToString(reader["RFID"]), Convert.ToBoolean(reader["Camping_Spot"]));
                }
            }
            catch { }
            finally { connection.Close(); }
            return v;
        }
        public List<string> getVistorHistory(int id)
        {
            //todo
            return null; ;
        }
        public Camping getSpotbyId(int id)
        {
            //todo
            return null;
        }
        public List<Visitors> getListOfVisitors()
        {//Get All Visitors from database

            List<Visitors> listVisitors = new List<Visitors>();
            Visitors v;
            connection.Open();
            MySqlCommand command = new MySqlCommand("Select * from visitor", connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    v = new Visitors(Convert.ToString(reader["first_name"]), Convert.ToString(reader["last_name"]), Convert.ToDateTime(reader["birthday"]), Convert.ToString(reader["phone"]), Convert.ToString(reader["email"]), Convert.ToString(reader["ticket_id"]), Convert.ToString(reader["rfid"]), Convert.ToBoolean(reader["Camping_Spot"]));
                    listVisitors.Add(v);
                }
            }

            catch { }
            finally
            {
                connection.Close();
            }
            return listVisitors;

        }
        public Item getItemById(int id)
        {
            //todo
            return null;
        }
        public Store getStorebyName(string name)
        {
            //todo
            return null;
        }

        /// <summary>
        /// Insert visitor after buying ticket at the entrance
        /// </summary>
        public void AddVisitorWithCamping(string fn, string ln, string bd, string ticketId, string rfid) 
        {
            List<string> listRfid = this.GetAvailableRFID();
            if (this.FindCampingSpot() != 0)
            {
                //string sql = string.Format("INSERT INTO dbi361552.visitor (ticket_id, rfid, spot_id, first_name, last_name, balance) VALUES ('" + ticketId + "', '" + listRfid[0] + "', " + FindCampingSpot() + ", '" + fn + "', '" + ln + "', 0);");
                string query = string.Format("INSERT INTO `visitor` (`visitor_id`, `ticket_id`, `rfid`, `spot_id`, `first_name`, `last_name`, `birthday`, `email`, `password`, `phone`, `balance`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', NULL, NULL, NULL, '0.00');", ticketId, rfid, this.FindCampingSpot(), fn, ln, bd);

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch { }
                finally { connection.Close(); }
            }
            else
            {
                MessageBox.Show("There is no more free camping spots available", "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Insert visitor after buying ticket at the entrance without camping spot
        /// </summary>
        public void AddVisitorNoCamping(string fn, string ln, string bd,string ticketId, string rfid)
        {
            List<string> listRfid = this.GetAvailableRFID();
            //string sql = string.Format("INSERT INTO dbi361552.visitor (ticket_id, rfid, spot_id, first_name, last_name, balance) VALUES ('" + ticketId + "', '" + listRfid[0] + "', " + DBNull.Value + ", '" + fn + "', '" + ln + "', 0);");
            string query = string.Format("INSERT INTO `visitor` (`visitor_id`, `ticket_id`, `rfid`, `spot_id`, `first_name`, `last_name`, `birthday`, `email`, `password`, `phone`, `balance`) VALUES (NULL, '{0}', '{1}', NULL, '{2}', '{3}', '{4}', NULL, NULL, NULL, '0.00');", ticketId, rfid, fn, ln, bd);
            
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
        }
        /// <summary>
        /// Update ticket table after visitor buying ticket at the entrance
        /// </summary>
        public void UpdateTicketTable(string ticketID) {
            string sql = string.Format("UPDATE ticket SET ticket_price={0} WHERE ticket_id='{1}'", 65, ticketID);
            MySqlCommand command = new MySqlCommand(sql, connection);
            try {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
        }
        /// <summary>
        /// Update camping spot table after visitor buys ticket at the entrance
        /// </summary>
        public void UpdateCampingSpotTable(int spotID, decimal spotPrice)
        {
            string query = string.Format("UPDATE camping_spot SET spot_price={0} WHERE spot_id={1}", spotPrice, spotID);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
        }
        public int FindCampingSpot() //finds free campingspot
        {
            int spot=0;
            string findSpot = string.Format("SELECT IFNULL(MIN(spot_id),0) from camping_spot WHERE spot_price is null");
            MySqlCommand cmd = new MySqlCommand(findSpot, connection);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                spot = Convert.ToInt32(result);
            }
            catch { }
            finally { connection.Close(); }
            return spot;
        }

        public List<string> GetAvailableTickets()
        {
            List<string> ticketList = new List<string>();
            string query = string.Format("SELECT ticket_id from ticket where ticket_price is null");
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticketList.Add(reader[0].ToString());
                }
            }
            catch { }
            finally { connection.Close(); }
          
            return ticketList;
        }

        public List<string> GetAvailableRFID()
        {
            List<string> rfidList = new List<string>();
            string query = string.Format("SELECT rfid from rfid where rfid not in (select rfid from visitor where rfid is not null);");
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rfidList.Add(reader[0].ToString());
                }
            }
            catch { }
            finally { connection.Close(); }

            return rfidList;
        }
    }
}