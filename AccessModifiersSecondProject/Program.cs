using AccessModifiersTestNamespace;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods that are available in instance of base class from another dll

            BaseClass1 baseInst = new BaseClass1();

            baseInst.PublicMethodBaseClass1();


            // Methods that are available in instance of ChildClass from another dll that inherits from BaseClass from another dll

            ChildClass1 childInst = new ChildClass1();

            childInst.PublicMethodBaseClass1();


            // Methods that are available by creating an instance of child class from this dll which inherits from BaseClass from another dll

            ChildClass2 externalChild = new ChildClass2();

            externalChild.InternalMethoChildClass2();

            externalChild.protectedInternalMethodChildClass2();

            externalChild.PublicMethodBaseClass1();

            externalChild.PublicMethodChildClass2();
        }
    }
}