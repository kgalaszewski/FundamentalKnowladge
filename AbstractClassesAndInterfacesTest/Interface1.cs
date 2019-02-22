namespace AbstractClassesAndInterfacesTest
{
    interface Interface1
    {
        // int number; error : interface can not contain fields

        int IntPropertyInterface1 { get; set; } // default access modifier is public for everything inside interface

        void VoidMethodInterface1();
    }
}
