using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // test method inheritance
            ChildClass cc = new ChildClass();
            GrandChildClass gcc = new GrandChildClass();

            Console.WriteLine("calling method from gcc");
            gcc.BaseMethod();
            gcc.ChildMethod();
            gcc.GrandChildMethod();
            Console.WriteLine();

            Console.WriteLine("calling method from cc");
            cc.BaseMethod();
            cc.ChildMethod();
            //cc.GrandChildMethod();
            Console.WriteLine();

            // test base class fields
            BaseClass bc = new BaseClass(123, 455);
            bc.PrintState();
            Console.WriteLine();

            // test child print state
            ChildClass cc2 = new ChildClass(987, 484, 398);
            cc2.PrintState();
        }
    }
}
