using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public class TextBox
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Font Font { get; set; }


        public TextBox ShallowCopy()
        {
            return (TextBox)this.MemberwiseClone();
        }

        public TextBox DeepCopy() 
        {
            TextBox clone = (TextBox)this.MemberwiseClone();
            clone.Font = new Font
            {
                Size = Font.Size,
                Color = Font.Color
            };
            return clone;
        }
    }
}
