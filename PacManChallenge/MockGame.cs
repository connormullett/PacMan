using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	class MockGame : IGame
	{
		public string[] GetGameInputs()
		{
			var list = new List<string>
			{
				"Dot",
				"InvincibleGhost",
				"VulnerableGhost",
				"Cherry"
			};

			return list.ToArray();
		}

		public void Start()
		{
			var Pac = new Pacman();
		}
	}
}
