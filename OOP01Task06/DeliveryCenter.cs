using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01Task06
{
    internal class DeliveryCenter
    {
        private Shipment[] _shipments;

        //ctor
        public DeliveryCenter(int capacity)
        {
            _shipments = new Shipment[capacity];
        }

        public Shipment this[int index]
        {
            get
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }
                return default;
            }
            set
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (_shipments != null)
                {
                    for (int i = 0; i < _shipments.Length; i++)
                    {
                        if (_shipments[i].TrackingCode == trackingCode)
                        {
                            return _shipments[i];
                        }
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            //if (_shipments == null)
            //{
            //    _shipments = new Shipment[10];
            //}

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (string.IsNullOrEmpty(_shipments[i].TrackingCode) || _shipments[i].TrackingCode == "UNKNOWN")
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
    }
}
