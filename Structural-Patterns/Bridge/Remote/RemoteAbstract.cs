using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Remote
{
    abstract public class RemoteAbstract
    {
        protected IDevice _device;
        public RemoteAbstract(IDevice device) 
        {
            _device = device;
        }

        public void SetVolumnUp(int number) 
        {
            int volumn = _device.Volumn + number;
            _device.SetVolumn(volumn);
        }

        public void SetVolumnDown(int number) 
        {
            int volumn = _device.Volumn - number;
            _device.SetVolumn(volumn);
        }

        public int GetVolumn()
        {
            return _device.GetVolumn();
        }
    }
}
