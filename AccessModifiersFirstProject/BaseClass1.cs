namespace AccessModifiersTestNamespace
{
    public class BaseClass1
    {
        public void exampleMethod()
        {
            // Methods that you can actually use in class by its own 

            PublicMethodBaseClass1();

            privateMethodBaseClass1();

            privateProtectedMethodBaseClass1();

            protectedMethodBaseClass1();

            protectedInternalMethodBaseClass1();

            InternalMethodBaseClass1();
        }

        public void PublicMethodBaseClass1()
        {
            // can be used in both this and child class, also by an instance of an object (both this and child class instance) in both this and external dll
            // means everywhere
        }

        internal void InternalMethodBaseClass1()
        {
            // can be used inside base class, inside child class (only in this dll) and by instance of both base and child class (both only in this dll)
            // means everywhere in this dll
        }

        protected internal void protectedInternalMethodBaseClass1()
        {
            // can be used in base class, in child class (in both this and external dll) and by instances of these classes, but only in this dll
            // means public in this dll, protected in external dll 
        }

        protected void protectedMethodBaseClass1()
        {
            // can be used base class and in child class, both in this and external dll child. Can not be used byinstance of child class or by instance of base class
            // means here and in child only (not only this dll)
        }

        // C# 7.2 or higher
        private protected void privateProtectedMethodBaseClass1()
        {
            // the same as protected method but for child in this dll only (not external)
            // means protected that doesnt work in external dll
        }

        private void privateMethodBaseClass1()
        {
            // can be used only inside the class that this method is implemented - for example in this class .... but you can use private method inside public method 
            // means here only
        }
    }
}
