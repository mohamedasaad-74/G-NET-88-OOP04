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
        }
    }
}
