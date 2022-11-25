using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IDevice
    {
        int Volumn { get; set; }
        int GetVolumn();
        void SetVolumn(int number);
    }
}
