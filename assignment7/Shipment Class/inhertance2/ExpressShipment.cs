using assignment7.Shipment_Class.assignment6.ship;
using assignment7.Shipment_Class.DeliveryAddress_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7.Shipment_Class.inhertance2
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee;
        public decimal extraFee
        {
            get { return ExtraFee; }
            set
            {
                if (value >= 0)
                {
                    ExtraFee = value;
                    return;
                }
                Console.WriteLine("Enter a value");
            }
        }
        public ExpressShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination, decimal extraFee) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
        {
            ExtraFee = extraFee;
        }
        public override decimal EstimatedCost
        {
            get { return deliveryfee + ((decimal)weight * 5) + extraFee; }
        }
        public override string ToString()
        {
            return $"Tracking code: {trackingcode}, " +
               $"Description : {description}, " +
                $"Weight : {weight}" +
                $"Delivryfee : {deliveryfee}" +
                $"Destination : {destination}" +
                $"Extrafee : {extraFee}" +
                $"EstimatedCost : {EstimatedCost} ";


        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"EstimatedCost : {EstimatedCost} ");
            Console.WriteLine($"Extrafee : {extraFee}");
        }



    }
}