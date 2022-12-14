using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ExternalSystem
{
    /// <summary>
    /// This is a external system class
    /// </summary>
    public class SubSystem2
    {
        public void DoSometing() 
        {
            Console.WriteLine("-------------------------------------- ");
            Console.WriteLine("This start SubSystem2 DoSometing() ");
            Console.WriteLine("DoSometing logic .... ");
            Console.WriteLine("End ");
            Console.WriteLine("-------------------------------------- ");
        }
    }
}
