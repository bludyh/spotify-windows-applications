using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrance_Application
{
    class Order
    {
        //fields
        public List<Visitors> orderList; //stores all the customers of an order
        private int counter = 0;
        private double ticketPrice = 65;
        private double campingSpotPrice = 20;
        private double reservationPrice = 10;
        private int ticketQuantity;
        private int campingSpotQuantity;
        private int reservationQuantity;
        private double totalPrice;
        private bool campingSpotFull = false;

        //properties
        public int TicketQuantity
        {
            get { return ticketQuantity; }
        }
        public int CampingSpotQuantity
        {
            get { return campingSpotQuantity; }
        }
        public int ReservationQuantity
        {
            get { return reservationQuantity; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
        }
        public bool CampingSpotFull
        {
            get { return campingSpotFull; }
        }

        public Order()
        {
            orderList = new List<Visitors>();
        }

        //methods
        public void AddTicket()
        {
            totalPrice += ticketPrice;
            ticketQuantity++;
        }
        public void RemoveTicket()
        {
            totalPrice -= ticketPrice;
            ticketQuantity--;
        }
        public void AddPersontoCamping()
        {
            counter++;
            if (counter == 1)
            {
                AddCampingSpot();
            }
            else if (counter == 6 /*|| counter == 12 || counter == 18*/)
            {
                campingSpotFull = true;
            }
            //else if (counter == 7 || counter == 13 || counter == 19)
            //{
            //    AddCampingSpot();
            //    campingSpotFull = false;
            //}
            else
            {
                campingSpotFull = false;
            }
            campingSpotQuantity++;
            totalPrice += campingSpotPrice;
        }
        public void removePersonFromCamping() //this method removes a person from a campingspot
        {
            counter--;
            if (counter == 0)
            {
                if (reservationQuantity > 0)
                {
                    RemoveCampingSpot();
                }
            }
            else if(counter == 6 /*|| counter == 12 || counter == 18*/)
            {
                RemoveCampingSpot();
                campingSpotFull = true;
            }
            else
            {
                campingSpotFull = false;
            }
            campingSpotQuantity--;
            totalPrice -= campingSpotPrice;
        }
        
        public void AddCampingSpot()
        {
            totalPrice += reservationPrice;
            reservationQuantity++;
        }
        public void RemoveCampingSpot()
        {
            totalPrice -= reservationPrice;
            reservationQuantity--;
        }
        public double GetTotalPrice() //returns the total price of the whole order
        {
            return totalPrice;
        }
        public string GetTicketTotal() //for displaying the price in the shopping cart
        {
            double total = ticketQuantity * ticketPrice;
            return "€" + Convert.ToString(total);
        }
        public string GetCampingTotal() //for displaying the price in the shopping cart
        {
            double total = campingSpotQuantity * campingSpotPrice;
            return "€" + Convert.ToString(total);
        }
        public string GetReservationTotal() //for displaying the price in the shopping cart
        {
            double total = reservationQuantity * reservationPrice;
            return "€" + Convert.ToString(total);
        }
            

        
        

    }
}
