using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application
{
    class RentalItem:Item
    {
        //fields
        private decimal deposit_price;
        private DateTime rentTime;
        private DateTime returnTime;

        //constructor
        public RentalItem(int id, string name, string category, decimal price, int quantity, decimal deposit, DateTime rent, DateTime returnn) : base(id, name, category, price, quantity,deposit) {
            this.deposit_price = deposit;
            this.rentTime = rent;
            this.returnTime = returnn;
        }

        //methods
        public override string ToString()
        {
            return base.ToString() + deposit_price;
        }
    }
}
