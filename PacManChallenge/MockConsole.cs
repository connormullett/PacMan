using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public class MockConsole : IConsole
	{
		public string ReadLine()
		{
			throw new NotImplementedException();
		}

		public void WriteLine(string s)
		{
			throw new NotImplementedException();
		}
	}
}
