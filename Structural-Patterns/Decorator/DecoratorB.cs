using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoratorB : Decorator
    {
        public DecoratorB(Component component) : base(component)
        { }

        public override string Operation()
        {
            return base.Operation() + "DEF";
        }
    }
}
