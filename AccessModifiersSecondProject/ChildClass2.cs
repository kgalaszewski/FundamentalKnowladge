using AccessModifiersTestNamespace;

namespace ConsoleApp9
{
    public class ChildClass2 : BaseClass1
    {
        public void exampleMethod() // base method exampleMethod can be hidden using ,, new '' 
        {
            // Methods that are available by inheriting from class from another dll

            protectedInternalMethodBaseClass1();

            PublicMethodBaseClass1();

            protectedMethodBaseClass1();
        }

        public void PublicMethodChildClass2()
        {

        }

        private void privateMethodChildClass2()
        {

        }

        protected void protectedMethodChildClass2()
        {

        }

        internal void InternalMethoChildClass2()
        {

        }

        // C# 7.2 or higher
        private protected void privateProtectedMethodChildClass2()
        {

        }

        protected internal void protectedInternalMethodChildClass2()
        {

        }
    }
}
