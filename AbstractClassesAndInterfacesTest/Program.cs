namespace AbstractClassesAndInterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------------------------------------------------------------------------------------------------------
            //Methods available for instance of class that inherits from 1 abstract class and 2 interfaces, created as : class object = new class()
            BasicClass BasicBasicObject = new BasicClass(); // N E W     O B J E C T        N E W     O B J E C T        N E W     O B J E C T

            // --- its own fields, properties and methods

            int _itsOwnInt = BasicBasicObject.itsOwnInt;

            int _ItsOwnIntProperty = BasicBasicObject.ItsOwnIntProperty;

            BasicBasicObject.ItsOwnMethod();

            // --- fields, properties and methods from abstract class and interfaces

            string __stringFieldAbstractClass = BasicBasicObject.stringFieldAbstractClass;

            char __CharPropertyAbstractClass = BasicBasicObject.CharPropertyAbstractClass;

            BasicBasicObject.AbstractMethodAbstractClass();

            BasicBasicObject.VirtualMethodAbstractClass();

            BasicBasicObject.VoidMethodAbstractClass();

            BasicBasicObject.VoidMethodInterface1();

            BasicBasicObject.VoidMethodInterface2(); 

            // does not contain properties of both interfaces, contains methods from both interfaces and everything from AbstractClass



            // --------------------------------------------------------------------------------------------------------------------------------------------------------
            // Methods available for instance of class that inherits from Abstract Class, created as : abstract class object = new realClass()
            AbstractClass AbstractBasicObject = new BasicClass(); // N E W     O B J E C T        N E W     O B J E C T        N E W     O B J E C T

            // does not contain any of its own (BasicClass) fields, properties or methods

            string _stringFieldAbstractClass = AbstractBasicObject.stringFieldAbstractClass;

            char _CharPropertyAbstractClass = AbstractBasicObject.CharPropertyAbstractClass;

            AbstractBasicObject.AbstractMethodAbstractClass();

            AbstractBasicObject.VirtualMethodAbstractClass();

            AbstractBasicObject.VoidMethodAbstractClass();

            // contains methods, properties and fields from Abstract Class (overriden and not overriden)


            // --------------------------------------------------------------------------------------------------------------------------------------------------------
            // Methods available for instance of class that implements Interface1
            Interface1 Interface1BasicObject = new BasicClass(); // N E W     O B J E C T        N E W     O B J E C T        N E W     O B J E C T

            // does not contain any of its own (BasicClass) fields, properties or methods

            int _IntPropertyInterface1 = Interface1BasicObject.IntPropertyInterface1;

            Interface1BasicObject.VoidMethodInterface1();

            // contains only properties and methods that were forced to implement by this interface1


            // --------------------------------------------------------------------------------------------------------------------------------------------------------
            // Methods available for instance of class that implements Interface2
            Interface2 Interface2BasicObject = new BasicClass(); // N E W     O B J E C T        N E W     O B J E C T        N E W     O B J E C T

            // does not contain any of its own (BasicClass) fields, properties or methods

            double _DoublePropertyInterface2 = Interface2BasicObject.DoublePropertyInterface2;

            Interface2BasicObject.VoidMethodInterface2();

            // contains only properties and methods that were forced to implement by this interface2
        }
    }
}
