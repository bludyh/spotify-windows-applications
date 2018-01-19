using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace QRCodeScanner
{
    class DataHelper
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

        //methods

        public Visitors GetVisitorInfo(string ticket)
        {
            connection.Open();
            string query = string.Format("SELECT COUNT(*) from visitor where ticket_id='{0}'", ticket);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if(count != 0)
            {
                string sql = string.Format("SELECT * FROM visitor  where ticket_id='{0}'", ticket);
                //  int spot = 0;
                MySqlCommand command = new MySqlCommand(sql, connection);
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["visitor_id"]);
                        string fname = (string)(reader["first_name"]);
                        string ln = (string)(reader["last_name"]);
                        DateTime bd = (DateTime)(reader["birthday"]);
                        string phone = null;
                        string email = (string)(reader["email"]);
                        string ticket_id = (string)(reader["ticket_id"]);

                        //  spot = Convert.ToInt32(reader["spot_id"]);

                        //string rrfid = (string)(reader["rfid"]);
                        //  v = new Visitors(Convert.ToString(reader["first_name"]), Convert.ToString(reader["last_name"]), Convert.ToDateTime(reader["birthday"]), Convert.ToString(reader["phone"]), Convert.ToString(reader["email"]), Convert.ToString(reader["ticket_id"]), Convert.ToString(reader["spot_id"]), Convert.ToString(reader["rfid"]));
                        v = new Visitors(id, fname, ln, bd, phone, email, ticket, "", 0);
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
                return v;
            }
            else
            {
                return null;
            }


        }

        public void AssignRFID(string ticket, string rfid)
        {

            string query = string.Format("UPDATE visitor set rfid='{0}' WHERE ticket_id='{1}';", rfid, ticket);
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }
        }

        public void InsertRFID(string rfid)
        {
            string query = string.Format("INSERT INTO rfid (rfid) VALUES ('{0}');", rfid);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

        }

        public bool CheckRFID(string rfid)
        {
            int count = 0;
            string query = string.Format("SELECT COUNT(*) from visitor where rfid='{0}'", rfid);
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch { }
            finally { connection.Close(); }

            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string GetRFID(string ticket)
        {
            string s = "";
            string query = string.Format("SELECT IFNULL(rfid, '') from visitor where ticket_id='{0}';", ticket);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                s = cmd.ExecuteScalar().ToString();
            }
            catch { }
            finally { connection.Close(); }
            return s;   
        }

        //public bool ValidTicket(string ticketId)
        //{
        //    bool valid = false;
        //    string query = string.Format("SELECT COUNT(*) from visitor where ticket_id='{0}';");
        //    MySqlCommand cmd = new MySqlCommand(query, connection);
        //    try
        //    {
        //        connection.Open();
        //        object count = (object)cmd.ExecuteScalar();
        //        if(count == DBNull.Value)
        //        {
        //            valid = true;
        //        }
        //        else
        //        {
        //            valid = false;
        //        }
        //    }
        //    catch { }
        //    finally { connection.Close(); }
        //    return valid;
        //}






    }
}
