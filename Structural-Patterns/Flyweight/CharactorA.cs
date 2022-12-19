using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public class CharactorA : Charator
	{
		public CharactorA() 
		{
			symbol = 'A';
			width = 100;
			height = 100;
			ascent = 70;
			descent = 0;
		}

		public override void Display()
		{
			Console.WriteLine($"symbol = {symbol}, size = {pointSize}");
		}

		public override void SetPointSize(int pointSize)
		{
			this.pointSize = pointSize;
		}
	}
}
