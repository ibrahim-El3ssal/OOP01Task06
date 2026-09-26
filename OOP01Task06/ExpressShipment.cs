using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task06
{
    internal class ExpressShipment : Shipment
    {
        private decimal _extraFee;
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get
            {
                return _extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value; 
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("--------------------------------------------------");
        }

    }
}