using assignment7.Shipment_Class.assignment6.ship;
using assignment7.Shipment_Class.DeliveryAddress_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7.Shipment_Class.inhertance1

{

    public class StandardShipment : Shipment
    {



        public StandardShipment(string TrackingCode, string Description, double Weight, decimal Delivryfee, DeliveryAddress Destination) : base(TrackingCode, Description, Weight, Delivryfee, Destination)
        {

        }

        public override string ToString()
        {

            return $"TrackingCode   {trackingcode} , Description : {description}. Weight : {weight},Destination : {destination}";
            ;

        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Estimed cost {EstimatedCost}");
        }
    }
}