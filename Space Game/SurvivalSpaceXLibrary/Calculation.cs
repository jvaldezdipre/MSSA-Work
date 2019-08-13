using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SurvivalSpaceXLibrary.Storage;

namespace SurvivalSpaceXLibrary
{
    public class Calculation
    {
        MainMenu done = new MainMenu();
        Planets p = new Planets();
		Storage s = new Storage();

		public void calAddGold(Character character)
        {
			try
			{
				double gold = 900;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());


				if (character.Storage.Coin < gold * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketPharvis();
				}

				else
					character.Storage.Coin -= n * gold;
					character.Storage.Gold += n;
					Console.WriteLine($"You now have {character.Storage.Coin} coins.");
					Console.WriteLine($"You now have {character.Storage.Gold} Gold");
					Console.ReadLine();
			}
			catch(Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddGold(character);
			}
		}
		public void calAddSilver(Character character)
		{
			try
			{
				double silver = 500;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < silver * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketPharvis();
				}

				else
					character.Storage.Coin -= n * silver;
				character.Storage.Silver += n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Silver} Silver");
				Console.ReadLine();
			}
			catch(Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddSilver(character);
			}

		}
		public void calAddCopper(Character character)
		{
			try
			{
				double copper = 150;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < copper * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketPharvis();
				}

				else
					character.Storage.Coin -= n * copper;
					character.Storage.Copper += n;
					Console.WriteLine($"You now have {character.Storage.Coin} coins.");
					Console.WriteLine($"You now have {character.Storage.Copper} Copper.");
					Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddCopper(character);
			}
		}
		public void calSubGold(Character character)
		{
			try
			{
				double gold = 1000;
				Console.WriteLine("How many do you want to Sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Gold == 0)
				{
					Console.WriteLine("You do not have any gold to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * gold;
				character.Storage.Gold -= n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Gold} Gold");
				Console.ReadLine();
			}
			catch(Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubGold(character);
			}
		}
		public void calSubSilver(Character character)
		{
			try
			{
				double silver = 600;
				Console.WriteLine("How many do you want to sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Silver == 0)
				{
					Console.WriteLine("You do not have any Silver to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * silver;
				character.Storage.Silver -= n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Silver} Silver");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubSilver(character);
			}

		}
		public void calSubCopper(Character character)
		{
			try
			{
				double copper = 250;
				Console.WriteLine("How many do you want to sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Copper == 0)
				{
					Console.WriteLine("You do not have any Copper to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * copper;
				character.Storage.Copper -= n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Copper} Copper.");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubCopper(character);
			}
		}

		//Planet Crystal
		public void calAddDiamond(Character character)
		{
			try
			{
				double diamond = 1000;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < diamond * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketCrystal();
				}

				else
					character.Storage.Coin -= n * diamond;
				character.Storage.Diamond += n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Diamond} Diamond");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddDiamond(character);
			}
		}
		public void calAddRuby(Character character)
		{
			try
			{
				double ruby = 700;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < ruby * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketCrystal();
				}

				else
					character.Storage.Coin -= n * ruby;
				character.Storage.Ruby += n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Ruby} Ruby");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddRuby(character);
			}

		}
		public void calAddSaphire(Character character)
		{
			try
			{
				double saphire = 200;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < saphire * n)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketCrystal();
				}

				else
					character.Storage.Coin -= n * saphire;
				character.Storage.Saphire += n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Saphire} Saphire");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calAddSaphire(character);
			}
		}
		public void calSubDiamond(Character character)
		{
			try
			{
				double diamond = 2000;
				Console.WriteLine("How many do you want to sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Diamond == 0)
				{
					Console.WriteLine("You do not have any Diamond to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * diamond;
					character.Storage.Diamond -= n;
					Console.WriteLine($"You now have {character.Storage.Coin} coins.");
					Console.WriteLine($"You now have {character.Storage.Diamond} Diamond");
					Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubDiamond(character);
			}

		}
		public void calSubRuby(Character character)
		{
			try
			{
				double ruby = 800;
				Console.WriteLine("How many do you want to sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Ruby == 0)
				{
					Console.WriteLine("You do not have any Ruby to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * ruby;
				character.Storage.Ruby -= n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Ruby} Ruby");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubRuby(character);
			}


		}
		public void calSubSaphire(Character character)
		{
			try
			{
				double saphire = 400;
				Console.WriteLine("How many do you want to sell?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Saphire == 0)
				{
					Console.WriteLine("You do not have any Saphire to sell. Please choose something else to sell.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.sellingStonks();
				}
				else
					character.Storage.Coin += n * saphire;
				character.Storage.Saphire -= n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"You now have {character.Storage.Saphire} Saphire");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calSubSaphire(character);
			}
		}

		//Planet BigAgua
		public void calHealth(Character character)
		{
			try
			{
				double health = 50;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < health)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketBigagua();
				}
				else
					character.Storage.Coin -= n * health;
				character.Storage.Health += 50 * n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"Your Health is now at {character.Storage.Health}%");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calHealth(character);
			}
		}


		//Planet Shell
		public void calFuel(Character character)
		{
			try
			{
				double fuel = 100;
				Console.WriteLine("How many do you want to buy?");
				double n = double.Parse(Console.ReadLine());
				if (character.Storage.Coin < fuel)
				{
					Console.WriteLine("Insuficient Funds you cannot buy this item. Please choose a different item.\n Press Enter to continue");
					Console.ReadLine();
					Console.Clear();
					p.marketShell();
				}
				else
					character.Storage.Coin -= n * fuel;
				character.Storage.Fuel += 50 * n;
				Console.WriteLine($"You now have {character.Storage.Coin} coins.");
				Console.WriteLine($"Your Fuel is now at {character.Storage.Fuel}%");
				Console.ReadLine();
			}
			catch (Exception)
			{
				Console.WriteLine("Wrong input use numbers");
				calFuel(character);
			}
		}

		public void Restart(Character character)
		{
			Character c = new Character();
			if (character.Storage.Health <= 0)
			{
				Console.Clear();
				Console.WriteLine($"Sorry but you died in Space.\n\nYou lost");
				done.Restart();
				//return character.Storage.Health;
			}
			else if (character.Storage.Fuel <= 0)
			{

				Console.Clear();
				Console.WriteLine($"Sorry but you ran out of fuel and you are now stuck in in Space.\n\nYou lost");
				done.Restart();
				//return character.Storage.Fuel;
			}

		}
	}
}
