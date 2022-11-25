using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Device
{
    public class TV : IDevice
    {
        public int Volumn { get; set; }

        public int GetVolumn()
        {
            return Volumn;
        }

        public void SetVolumn(int number)
        {
            Volumn = number;
        }
    }
}
