using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal chargePayment;
        private decimal chargeWrapPayment;
        private decimal chargeGSTPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal ChargePayment
        {
            get { return chargePayment; }
            set { chargePayment = value; }
        }
        public decimal ChargeWrapPayment
        {
            get { return chargeWrapPayment; }
            set { chargeWrapPayment = value; }
        }
        public decimal ChargeGSTPayment
        {
            get { return chargeGSTPayment; }
            set { chargeGSTPayment = value; }
        }
        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }
        public void calChargePayment()
        {
            ChargePayment = Price * Quantity + 25;
        }
        public void calChargeWrapPayment()
        {
            ChargeWrapPayment = Price * Quantity + 25 + 5;
        }
        public void calChargeGSTPayment()
        {
            decimal GST = 1.1m;
            ChargeGSTPayment = (Price * Quantity + 25 + 5) * GST;
        }
    }
}
