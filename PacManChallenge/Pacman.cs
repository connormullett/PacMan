using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public class Pacman
	{
		public int Points { get; set; }

		public int Lives { get; set; }

		public int BonusFactor { get; set; }

		public int NextLife { get; set; }

		public int LivesGained { get; set; }

		public Pacman()
		{
			Points = 5000;
			Lives = 3;
			BonusFactor = 0;
			NextLife = 0;
			LivesGained = 0;
		}
	}
}
