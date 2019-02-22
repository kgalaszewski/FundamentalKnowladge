using System;

namespace AbstractClassesAndInterfacesTest
{
    public class BasicClass : AbstractClass, Interface1, Interface2
    {
        // Its own field, property and method

        public int itsOwnInt;

        public int ItsOwnIntProperty { get; set; }

        public void ItsOwnMethod()
        {

        }



        // Abstract Class 

        // any method that is overriden, can be marked as seald, which tells that this method cant be overriden if some class inherits from this class, 
        // this method still can be overloaded in this class
        public override sealed void AbstractMethodAbstractClass() 
        {
            Console.WriteLine("forced to implement");
        }

        public override void VirtualMethodAbstractClass() // does not need to be overriden, ,,virtual'' allows but doesnt force
        {
            Console.WriteLine("overriden virtual method that is calling base version of this method");
            base.VirtualMethodAbstractClass();
        }

        // Interface1

        int Interface1.IntPropertyInterface1 { get; set; }

        public void VoidMethodInterface1()
        {
            Console.WriteLine("forced to implement due to implementing Interface1");
        }

        // Interface2

        double Interface2.DoublePropertyInterface2 { get; set; }      

        public void VoidMethodInterface2()
        {
            Console.WriteLine("forced to implement due to implementing Interface2");
        }
    }
}
