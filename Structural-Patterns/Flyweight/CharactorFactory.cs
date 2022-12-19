using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
	public class CharactorFactory
	{
		private Dictionary<string, Charator> dic = new Dictionary<string, Charator>();
		public CharactorFactory() 
		{
			//dic.Add("A", new CharactorA());
			//dic.Add("B", new CharactorB());
			//dic.Add("C", new CharactorC());
		}

		public Charator GetCharator(string key) 
		{
			if (dic.ContainsKey(key))
			{
				return dic[key];
			}
			else 
			{
				Charator charator = null;
				if (key == "A")
				{
					charator = new CharactorA();
				} 
				else if (key == "B")
				{
					charator = new CharactorB();
				}
				else if (key == "C")
				{
					charator = new CharactorC();
				}
				else 
				{
					throw new ArgumentNullException();
				}

				dic.Add(key, charator);

				return charator;
			}
		}
	}
}
