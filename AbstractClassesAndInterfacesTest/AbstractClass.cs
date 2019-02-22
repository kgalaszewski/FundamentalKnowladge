using System;

namespace AbstractClassesAndInterfacesTest
{
    public abstract class AbstractClass
    {
        // fields
        public string stringFieldAbstractClass;

        // properties
        public char CharPropertyAbstractClass { get; set; }


        // methods 
        public void VoidMethodAbstractClass()
        {

        }

        public virtual void VirtualMethodAbstractClass()
        {
            Console.WriteLine("virtual method inside AbstractClass");
        }

        public abstract void AbstractMethodAbstractClass();        
    }
}
