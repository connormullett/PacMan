using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public class Ghost
	{
		public bool IsVulnerable { get; set; }

		public int BonusFactor { get; set; }

		public Ghost()
		{
			BonusFactor = 200;
		}
	}
}
