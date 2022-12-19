using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public class CharactorB : Charator
	{
		public CharactorB()
		{
			symbol = 'B';
			width = 200;
			height = 200;
			ascent = 30;
			descent = 30;

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
