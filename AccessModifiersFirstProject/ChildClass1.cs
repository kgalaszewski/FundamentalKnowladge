namespace AccessModifiersTestNamespace
{
    public class ChildClass1 : BaseClass1
    {
        public new void exampleMethod() // base method exampleMethod can be hidden using ,, new '' 
        {
            // Available methods from inharitance from BaseClass

            privateProtectedMethodBaseClass1();

            protectedMethodBaseClass1();

            protectedInternalMethodBaseClass1();

            PublicMethodBaseClass1();

            InternalMethodBaseClass1();
        }

        private void privateMethodChildClass1()
        {

        }

        protected void protectedMethodChildClass1()
        {

        }

        internal void InternalMethodChildClass1()
        {

        }

        // C# 7.2 or higher
        private protected void privateProtectedMethodChildClass1()
        {

        }

        protected internal void protectedInternalMethodChildClass1()
        {

        }
    }
}
