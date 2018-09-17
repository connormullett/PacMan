using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public interface IGame
	{
		void Start();
		string[] GetGameInputs();
	}
}
