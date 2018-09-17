using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManChallenge
{
	public class Game : IConsole, IGame
	{
		private readonly IConsole _console;
		private readonly IGame _game;

		public Game(IConsole console)
		{
			_console = console;
		}

		public Game(IConsole console, IGame game)
		{
			_console = console;
			_game = game;
		}

		public void Start()
		{
			Pacman pac = new Pacman();
			Ghost ghost = new Ghost();
			var first = true;		

			while (first)
			{

				for (int i = 0; i < GetGameInputs().Length; i++)
				{
					if (first) pac.NextLife += 5000;

					first = false;

					var thisInput = GetGameInputs()[i];

					switch (thisInput)
					{
						case "Dot":
							pac.Points += 10;
							pac.NextLife += 10;
							break;
						case "InvincibleGhost":
							pac.Lives--;
							break;
						case "VulnerableGhost":
							pac.Points += ghost.BonusFactor;
							pac.NextLife += ghost.BonusFactor;
							ghost.BonusFactor *= 2;
							break;
						default:
							var bonus = Bonus._bonuses[thisInput];
							pac.Points += bonus;
							pac.NextLife += bonus;
							break;
					}

					if (pac.NextLife >= 10000)
					{
						pac.Lives++;
						pac.LivesGained++;
						pac.NextLife = 0;
					}
				}
			}

			_console.WriteLine($"Points: {pac.Points}");
			_console.WriteLine($"Lives: {pac.Lives}");
			_console.WriteLine($"Lives Gained: {pac.LivesGained}");
			_console.ReadLine();
		}

		public string[] GetGameInputs()
		{
			return File.ReadAllText(@"../../GameInput.Txt").Split(',');
		}

		public void WriteLine(string s)
		{
			Console.WriteLine(s);
		}

		public string ReadLine()
		{
			return Console.ReadLine();
		}

		//TODO: Unit test this shit
	}
}
