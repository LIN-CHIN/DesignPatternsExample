using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Remote
{
    public class BaseRemote : RemoteAbstract
    {
        public BaseRemote(IDevice device) : base(device) { }

    }
}
