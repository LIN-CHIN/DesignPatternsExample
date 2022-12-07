using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoratorA : Decorator
    {
        public DecoratorA(Component component) : base(component) 
        {}

        public override string Operation()
        {
            return base.Operation() + "ABC";
        }
    }
}
