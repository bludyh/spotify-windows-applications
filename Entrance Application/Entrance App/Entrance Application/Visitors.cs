using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrance_Application
{
    class Visitors
    {
        //fields
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private string email;
        private string phone;
        private string ticket_id;
        private int spot_id;
        private string rfid;
        private bool campingSpot;

        public Visitors(string fname, string lname, DateTime bd, string phone, string email, string ticketId, string rfid, bool campingSpot)
        {
            //  this.id = id;
            this.firstName = fname;
            this.lastName = lname;
            this.birthday = bd;
            this.phone = phone;
            this.email = email;
            this.ticket_id = ticketId;
            //this.spot_id = campingId;
            this.rfid = rfid;
            this.campingSpot = campingSpot;
        }
        //properties
        public int Id { set; get; }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Ticket_id
        {
            get { return ticket_id; }
            set { ticket_id = value; }
        }
        public int Spot_id
        {
            get { return spot_id; }
            set { spot_id = value; }
        }
        public string Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }
        public bool CampingSpot
        {
            get { return campingSpot; }
            set { campingSpot = value; }
        } 
            
            
        //methods
        public string AsString() //optional method for a listbox containing info about each customer - suggestion from Roopali
        {
            string s = "Name: " + firstName + " " + lastName + " ";

            if (campingSpot == true)
            {
                s += " reserved a camping spot!";
            }
            else
            {
                s += " did not reserve a camping spot!";
            }

            return s;
        }
    }
}
