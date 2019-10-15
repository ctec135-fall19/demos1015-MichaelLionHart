﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        // fields
        private int basePrivateInt;
        protected int baseProtectedInt;

        // constructors
        public BaseClass() { }
        public BaseClass(int privateint, int protectedint) 
        {
            this.basePrivateInt = privateint;
            this.baseProtectedInt = protectedint;
        }
        
        // methods
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod");
        }

        public virtual void PrintState()
        {
            Console.WriteLine("BaseClass object");
            Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
            
        }
    }
}
