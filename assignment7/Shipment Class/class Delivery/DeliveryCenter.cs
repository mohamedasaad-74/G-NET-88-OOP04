using assignment7.Shipment_Class.assignment6.ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7.Shipment_Class.class_Delivery
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public string CenterName { get; set; }

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
            count = 0;
        }

        public DeliveryCenter(string centerName) : this()
        {
            CenterName = centerName;
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return shipments[index];

                return default;
            }

            set
            {
                if (index >= 0 && index < count)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].trackingcode == trackingCode)
                        return shipments[i];
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (count >= shipments.Length)
                return false;

            shipments[count] = shipment;
            count++;

            return true;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].trackingcode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[count - 1] = null;
                    count--;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            if (count == 0)
            {
                Console.WriteLine("No shipments found.");
                return;
            }

            Console.WriteLine($"Center: {CenterName}");
            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    s.PrintShipment();
                }
            }
        }
    }
}