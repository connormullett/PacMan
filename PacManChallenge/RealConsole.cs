using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public class RealConsole : IConsole
	{
		public void WriteLine(string s)
		{
			Console.WriteLine(s);
		}

		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}
