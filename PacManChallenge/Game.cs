using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public static class Game
	{
		public static void Start()
		{
			Pacman pac = new Pacman();
			Ghost ghost = new Ghost();

			for (int i = 0; i < GetGameInputs().Length; i++)
			{
				if (pac.Lives == 0) break;

				//do lives for 10,000 plus (new variable called pointsToNextLife)
				pac.NextLife = 0;

				var thisInput = GetGameInputs()[i];

				switch (thisInput)
				{
					case "Dot":
						pac.Points += 10;
						break;
					case "InvincibleGhost":
						pac.Lives -= 1;
						break;
					case "VulnerableGhost":
						pac.Points += ghost.BonusFactor;
						ghost.BonusFactor *= 2;
						break;
					default:
						pac.Points += Bonus._bonuses[thisInput];
						break;
				}
			}

			if (pac.NextLife > 10000)
			{
				pac.Lives += 1;
				pac.LivesGained += 1;
			}

			Console.WriteLine($"Points: {pac.Points}");
			Console.WriteLine($"Lives: {pac.Lives}");
			Console.WriteLine($"Lives Gained: {pac.LivesGained}");
		}

		public static string[] GetGameInputs()
		{
			string text = File.ReadAllText(@"../../GameInput.Txt");
			var list = text.Split(',');
			return list;
		}
	}
}
