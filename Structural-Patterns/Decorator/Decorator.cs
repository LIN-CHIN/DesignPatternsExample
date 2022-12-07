﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;
        public Decorator(Component component) 
        {
            _component = component;   
        }

        public override string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else 
            {
                return string.Empty;   
            }
        }
    }
}
