using Facade.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Application
    {
        private readonly ISubSystem _subSystem;

        public Application(ISubSystem subSystem) 
        {
            _subSystem = subSystem;
        }

        public void Start() 
        {
            _subSystem.OperacateSubSystem();
        }
    }
}
