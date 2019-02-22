namespace AbstractClassesAndInterfacesTest
{
    interface Interface2
    {
        // int number; error : interface can not contain fields

        double DoublePropertyInterface2 { get; set; } // default access modifier is public for everything inside interface

        void VoidMethodInterface2();
    }
}
