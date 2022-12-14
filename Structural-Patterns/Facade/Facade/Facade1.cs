using Facade.ExternalSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Facade
{
    /// <summary>
    /// This is a facade,  can be replaced with Facade2
    /// </summary>
    public class Facade1 : ISubSystem
    {
        private readonly SubSystem1 _subSystem1; 
        private readonly SubSystem2 _subSystem2;

        public Facade1(SubSystem1 subSystem1, SubSystem2 subSystem2) 
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
        }

        public void OperacateSubSystem()
        {
            _subSystem1.SendMsg();
            _subSystem2.DoSometing();
        }
        
    }
}
