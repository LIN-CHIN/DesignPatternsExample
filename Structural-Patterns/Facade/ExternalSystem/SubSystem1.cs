using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ExternalSystem
{
    /// <summary>
    /// This is a external system class
    /// </summary>
    public class SubSystem1
    {
        public void SendMsg() 
        {
            Console.WriteLine("-------------------------------------- ");
            Console.WriteLine("This start SubSystem1 SendMsg() ");
            Console.WriteLine("SendMsg logic .... ");
            Console.WriteLine("End ");
            Console.WriteLine("-------------------------------------- ");
        }
    }
}
