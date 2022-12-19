using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public class Application
	{
		public void Start() 
		{
			CharactorFactory factory = new CharactorFactory();


			Charator charator = factory.GetCharator("A");
			charator.SetPointSize(50);
			charator.Display();

			Charator charator2 = factory.GetCharator("A");
			charator2.SetPointSize(500);


			charator.Display();
			charator2.Display();
		}
	}
}
