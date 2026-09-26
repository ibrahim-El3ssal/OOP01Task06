using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task06
{
    internal class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        public string DestinationCountry 
        { 
            get { return _destinationCountry;  }
            set
            {
                if(! string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value; 
                }
            } 
        }

        private decimal _customsFee ; 
        public decimal CustomsFee 
        {
            get { return _customsFee; }
            set
            {
                if(value >= 0)
                    _customsFee = value; 
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }



        public InternationalShipment(string destinationCountry , decimal customsFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry; 
            CustomsFee = customsFee;
        }
    }
}
