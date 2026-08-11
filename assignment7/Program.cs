using assignment7.Shipment_Class.assignment6.ship;
using assignment7.Shipment_Class.class_Delivery;
using assignment7.Shipment_Class.DeliveryAddress_class;
using assignment7.Shipment_Class.DeliveryHelperclass;
using assignment7.Shipment_Class.Driverclass;
using assignment7.Shipment_Class.inhertance1;
using assignment7.Shipment_Class.inhertance2;
using assignment7.Shipment_Class.inhertance3;
using assignment7.Shipment_Class.inhertance4;
using assignment7.Shipment_Class.inhertance5;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //a)  What is the difference between Method Overloading and Method Overriding?
            //======================= Overloading==============
            // اللي هدفها غرض واحدfunctionبتهدف لاني معملش زيياده في اسامي ال 
            //بتحمل نفس الاسم 
            //ال parmeters بيكونو مختلفين اما من حيث نوعهم او عددهم 
            //==================================================

            //=============Method Overriding================
            //parentهو وارثها من ال function يقدر يعدل علي childهدفها انها تخلي ال 
            //بنستخدم override عند child ,virtual عند parent
            //========================================================

            //b)  What is the difference between Static Binding and Dynamic Binding?

            //============Static Binding==============
            //compile time بتستكشف وقت ال 
            //  child ال  function وبتكون عند newبنستخدم فيها  
            // انه يعيد استخدمهاparent لا يمكن لل 
            //===============================================
            //=======================Dynamic Binding======
            //run time بتستكشف وقت ا
            //بنستخدم override عند child ,virtual عند parent
            // انه يعيد استخدمهاparent  يمكن ل
            #endregion

            #region Question2
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //sealed keyword ==بتمنع اني اورث من الكلاس 
            //================================================

            //b)  What is the difference between a sealed class and a sealed method?
            //=================sealed class=================
            //بتمنع التوريث من الكلاس كامل 

            //=====================sealed method==================
            //  دي داله جوا الكلاس ممنوع الابن يعدل عليها لاكن في وراثه عادي 
            //===================================================

            //c)  Can a sealed method be overridden? Why?
            // بتمنع التعديل علي الداله sealed methodلا مينفعش لان ال
            //=======================================================
            #endregion

            #region Practical
            //// a. Create a Driver.
            //Driver driver = new Driver("D101", "Ahmed Ali");

            //// b. Create a DeliveryCenter.
            //DeliveryCenter center = new DeliveryCenter("Cairo Main Center");

            //// d. Create one StandardShipment.
            //DeliveryAddress address = new DeliveryAddress("Street 10", "Cairo", 74);
            //StandardShipment standard = new StandardShipment("SH101", "Books", 2.5, 50m, address);

            //// e. Create one ExpressShipment.
            //ExpressShipment express = new ExpressShipment("SH102", "Laptop", 3.0, 100m, address, 20m);

            //// f. Create one InternationalShipment.
            //InternationalShipment international = new InternationalShipment("SH103", "Phone", 1.2, 150m, address, 30m, "USA");

            //// g. Add all shipments to the DeliveryCenter.
            //center.AddShipment(standard);
            //center.AddShipment(express);
            //center.AddShipment(international);

            //// h. Print all shipments using PrintAllShipments().
            //Console.WriteLine("=== All Shipments in Delivery Center ===");
            //center.PrintAllShipments();

            //// i. Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            //Console.WriteLine("\n=== DeliveryHelper Output ===");
            //DeliveryHelper.PrintShipmentDetails(standard);
            //DeliveryHelper.PrintShipmentDetails(express);
            //DeliveryHelper.PrintShipmentDetails(international);

            //// j. Demonstrate both versions of UpdateWeight().
            //Console.WriteLine("\n=== Demonstrate UpdateWeight() Overloading ===");
            //standard.UpdateWeight(3.5);
            //standard.UpdateWeight(1.0,1.3);

            //// k. Build a Shipment[] holding mixed types and print all of them in a loop.
            //Console.WriteLine("\n=== Mixed Shipment Array Loop ===");
            //Shipment[] mixedShipments = new Shipment[]
            //{
            //    standard,
            //    express,
            //    international,
            //    new PriorityInternationalShipment("SH104", "Medical Equipment", 5.0, 200m, address, 50m, "Germany")
            //};

            //foreach (Shipment shipment in mixedShipments)
            //{
            //    shipment.PrintShipment();
            //    Console.WriteLine("-----------------------------");
            //}

            //// 10. Demonstrate the sealed class and sealed method (comments or code).
            //Console.WriteLine("\n=== Sealed Class & Sealed Method Demo ===");
            //CompletedShipment completed = new CompletedShipment("SH105", "Documents", 0.5, 30m, address);
            //completed.PrintShipment();

            //PriorityInternationalShipment priority = new PriorityInternationalShipment("SH106", "Urgent Spare Parts", 4.0, 250m, address, 60m, "UK");
            //priority.GenerateCustomsReport();
        }
    }

            #endregion
}
    

