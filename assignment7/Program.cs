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
        }
    }
}
