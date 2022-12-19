using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public abstract class Charator
	{
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize; 

        public abstract void Display();
        public abstract void SetPointSize(int pointSize);

    }
}
