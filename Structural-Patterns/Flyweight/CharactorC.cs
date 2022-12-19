using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public class CharactorC : Charator
	{
		public CharactorC()
		{
			symbol = 'C';
			width = 500;
			height = 500;
			ascent = 300;
			descent = 300;

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
