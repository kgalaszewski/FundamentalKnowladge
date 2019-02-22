namespace AccessModifiersTestNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass1 Child = new ChildClass1();

            // Methods available from instance of child class that inherits from base class

            Child.InternalMethodBaseClass1();

            Child.InternalMethodChildClass1();

            Child.protectedInternalMethodBaseClass1();

            Child.protectedInternalMethodChildClass1();

            Child.PublicMethodBaseClass1();


            // Methods available from instance of base class 

            BaseClass1 Base = new BaseClass1();

            Base.InternalMethodBaseClass1();

            Base.protectedInternalMethodBaseClass1();

            Base.PublicMethodBaseClass1();
        }
    }
}