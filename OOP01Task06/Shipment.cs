using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task06
{
    internal class Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return _trackingCode; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            _weight = weight > 0 ? weight : 1.0;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50.0m;

            Destination = destination;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1.0, 50.0m, new DeliveryAddress("Cairo", "Main St.", 1)) { }

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine($"\n Shipment Details ");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee:C}");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost:C}");
            Console.WriteLine(new string('-', 25));
        }
    }
}
