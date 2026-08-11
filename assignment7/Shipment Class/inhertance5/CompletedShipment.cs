using assignment7.Shipment_Class.assignment6.ship;
using assignment7.Shipment_Class.DeliveryAddress_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7.Shipment_Class.inhertance5
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress deliveryAddress)
            : base(trackingCode, description, weight, deliveryFee, deliveryAddress)
        {

        }

           
        }
}

