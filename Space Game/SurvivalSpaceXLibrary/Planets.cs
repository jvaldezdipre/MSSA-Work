using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalSpaceXLibrary
{

    public class Planets
    {
		public static Calculation s = new Calculation();
		public static Planets p = new Planets();		
		public static Character character = new Character();
		public static MainMenu done = new MainMenu();


		public void Inventory()
		{

			Console.WriteLine($"You have {character.Storage.Coin} coins.\n Health: {character.Storage.Health}%" +
				$"\n Fuel: {character.Storage.Fuel}%\n Gold: {character.Storage.Gold}\n Silver: {character.Storage.Silver}" +
				$"\n Copper: {character.Storage.Copper}\n Diamond: {character.Storage.Diamond}\n Ruby: {character.Storage.Ruby}" +
				$"\n Saphire: {character.Storage.Saphire}");
		}

		public void Pharvis()
        {
			
			//Planets p = new Planets();
			
			Console.WriteLine("Welcome to PHARVIS!!!");
            Console.WriteLine("---------------------\nPress Enter to continue");
            Console.ReadLine();
			Console.WriteLine($"Your health is at {character.Storage.Health -= 15}%");
			Console.WriteLine($"Your fuel is at {character.Storage.Fuel -= 25}%");
			
			Console.ReadLine();
			Console.Clear();
			marketPharvis();
			
		}
		public void marketPharvis()
		{
			Inventory();
			Console.WriteLine("\n1 - Gold = 900 coins\n2 - Silver = 500 coins\n3 - Copper = 150 coins\n4 - Switch Planet\n5 - Earth");
			Console.Write("\nWhat do you want?: ");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();


			

			switch (choose)
			{
				case "1":		
					s.calAddGold(character);
					break;

				case "2":
					s.calAddSilver(character);
					break;

				case "3":	
					s.calAddCopper(character);
					break;

				case "4":
					Console.Clear();
					Console.WriteLine("Please Choose another planet");
					s.Restart(character);
					character.callPlanets();
					break;

				case "5":
					Earth();
					break;
				default:
					Console.WriteLine("Wrong Input Try again");
					marketPharvis();
					break;

			}
			Console.WriteLine("Are you done shopping?\n1 - Yes\n2 - No");
			Console.Write(">> ");
			string leave = Console.ReadLine().ToString();

			while (leave != "1" && leave != "2")
			{
				Console.WriteLine("Wrong Input Try again");
				Console.Write(">> ");
				leave = Console.ReadLine().ToString();
			}

			if (leave == "1")
			{
				Console.Clear();
				Console.WriteLine("Please Choose another planet");
				s.Restart(character);
				character.callPlanets();
			}
			else if (leave == "2")
			{
				Console.Clear();
				p.marketPharvis();
			}
		}


        public void Crystal()
        {

			Console.WriteLine("Welcome to CRYSTAL!!!");
            Console.WriteLine("---------------------\nPress Enter to continue");
            Console.ReadLine();
			Console.WriteLine($"Your health is at {character.Storage.Health -= 15}%");
			Console.WriteLine($"Your fuel is at {character.Storage.Fuel -= 25}%");
			Console.WriteLine($"You have {character.Storage.Coin} coins\nPress Enter to Continue.");
			Console.ReadLine();
			Console.Clear();
			p.marketCrystal();
			
		}
		public void marketCrystal()
		{
			Inventory();
			
			Console.WriteLine("\nWe Have!");
			Console.WriteLine("\n1- Diamonds = 1000 coins\n2- Silver = 700 coins\n3- Sapphire = 200 coins\n4- Switch Planet\n5- Earth");
			Console.Write("\nChoose what do you want to buy? :");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();

			switch (choose)
			{
				case "1":
					
					s.calAddDiamond(character);
					break;
				case "2":
					
					s.calAddRuby(character);
					break;
				case "3":
					
					s.calAddSaphire(character);
					break;
				case "4":
                    Console.Clear();
					Console.WriteLine("Please Choose another planet");
					s.Restart(character);
					character.callPlanets();
					break;
				case "5":
					Earth();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Wrong Input Try again");
					marketCrystal();
					break;
				
			}
			Console.WriteLine("Are you done shopping?\n1 - Yes\n2 - No");
			Console.Write(">> ");
			string leave = Console.ReadLine().ToString();

			while (leave != "1" && leave != "2")
			{
				Console.WriteLine("Wrong Input Try again");
				Console.Write(">> ");
				leave = Console.ReadLine().ToString();
			}

			if (leave == "1")
			{
				Console.Clear();
				Console.WriteLine("Please Choose another planet");
				s.Restart(character);
				character.callPlanets();
			}
			else if (leave == "2")
			{
				Console.Clear();
				p.marketCrystal();
			}

		}


        public void Shell()
        {
            Console.WriteLine("Welcome to SHELL!!!");
            Console.WriteLine("---------------------\nPress Enter to continue");
            Console.ReadLine();
			Console.WriteLine($"Your health is at {character.Storage.Health -= 15}%");
			Console.WriteLine($"Your fuel is at {character.Storage.Fuel -= 25}%");
			Console.WriteLine($"You have {character.Storage.Coin} coins\nPress Enter to Continue.");
			Console.ReadLine();
			Console.Clear();
			p.marketShell();

		}
		public void marketShell()
		{
			Inventory();
			
			Console.WriteLine("\nWe Have!");
			Console.WriteLine("\n1- Fuel 100 coins\n2- Switch Planet\n3- Earth");
			Console.Write("\nChoose what do you want to buy? :");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();

		
			switch (choose)
			{
				case "1":
					var Fuel = new Calculation();
					Fuel.calFuel(character);
					break;
				case "2":
					Console.WriteLine("Please Choose another planet");
					
					s.Restart(character);
					character.callPlanets();
					break;
				case "3":
					Earth();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Wrong Input Try again");
					marketShell();
					break;
				

			}

			Console.WriteLine("Are you done shopping?\n1 - Yes\n2 - No");
			Console.Write(">> ");
			string leave = Console.ReadLine().ToString();

			while (leave != "1" && leave != "2")
			{
				Console.WriteLine("Wrong Input Try again");
				Console.Write(">> ");
				leave = Console.ReadLine().ToString();
			}

			if (leave == "1")
			{
				Console.Clear();
				Console.WriteLine("Please Choose another planet");
				s.Restart(character);
				character.callPlanets();
			}
			else if (leave == "2")
			{
				Console.Clear();
				p.marketShell();
			}

		}


        public void Bigagua()
        {
            Console.WriteLine("Welcome to BIG AGUA!!!");
            Console.WriteLine("---------------------\nPress Enter to continue");
            Console.ReadLine();
			Console.WriteLine($"Your health is at {character.Storage.Health -= 15}%");
			Console.WriteLine($"Your fuel is at {character.Storage.Fuel -= 25}%");
			Console.WriteLine($"You have {character.Storage.Coin} coins\nPress Enter to Continue.");
			Console.ReadLine();
			Console.Clear();
			p.marketBigagua();
			
		}
		public void marketBigagua()
		{
			Inventory();
			
			Console.WriteLine("\nWe Have!");
			Console.WriteLine("\n1- Health 50 coins\n2- Switch Planet\n3- Earth");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();


			switch (choose)
			{
				case "1":
					s.calHealth(character);
					break;

				case "2":
					Console.WriteLine("Please Choose another planet");
					s.Restart(character);
					character.callPlanets();
					break;

				case "3":
					Earth();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Wrong Input Try again");
					marketBigagua();
					break;

			}

			Console.WriteLine("Are you done shopping?\n1 - Yes\n2 - No");
			string leave = Console.ReadLine().ToString();

			while (leave != "1" && leave != "2")
			{
				Console.WriteLine("Wrong Input Try again");
				Console.Write(">> ");
				leave = Console.ReadLine().ToString();
			}

			if (leave == "1")
			{
				Console.Clear();
				Console.WriteLine("Please Choose another planet");
				s.Restart(character);
				character.callPlanets();
			}
			else if (leave == "2")
			{
				Console.Clear();
				p.marketBigagua();
			}
		}


        public void Stonks()
        {
            Console.WriteLine("Welcome to STONKS!!!");
            Console.WriteLine("---------------------\nPress Enter to continue");
            Console.ReadLine();
			Console.WriteLine($"Your health is at {character.Storage.Health -= 15}%");
			Console.WriteLine($"Your fuel is at {character.Storage.Fuel -= 25}%");
			Console.WriteLine($"You have {character.Storage.Coin} coins\nPress Enter to Continue.");
			Console.ReadLine();
			Console.Clear();
			p.sellingStonks();	
        }
		public void sellingStonks()
		{
			Inventory();
			Console.WriteLine("\nWe Buy Your Items!!!\nWhat do have?\n Press Enter to Continue");
			Console.ReadLine();
			Console.WriteLine("Here's a list and price of everthing I buy");
			Console.WriteLine("1 - Gold 1000 coins\n2 - Silver 600 coins\n3 - Copper 250 coins\n4 - Diamond 2000 coins\n5 - Ruby 800 coins\n6 - Saphire 400 coins\n7 - Switch Planets\n8 - Go back to earth.");
			Console.Write("What do you want to sell");
			Console.Write(">> ");
			string sell = Console.ReadLine().ToString();

			switch (sell)
			{
				case "1":
					s.calSubGold(character);
					break;

				case "2":
					s.calSubSilver(character);
					break;

				case "3":
					s.calSubCopper(character);
					break;

				case "4":
					s.calSubDiamond(character);
					break;

				case "5":
					s.calSubRuby(character);
					break;

				case "6":
					s.calSubSaphire(character);
					break;

				case "7":
					Console.Clear();
					Console.WriteLine("Please Choose another planet");
					s.Restart(character);
					character.callPlanets();
					break;

				case "8":
					Earth();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Wrong Input Try again");
					sellingStonks();
					break;
			}

            Console.WriteLine("Are you done shopping?\n1 - Yes\n2 - No");
			Console.Write(">> ");
			string leave = Console.ReadLine().ToString();

			while (leave != "1" && leave != "2")
			{
				Console.WriteLine("Wrong Input Try again");
				Console.Write(">> ");
				leave = Console.ReadLine().ToString();
			}

			if (leave == "1")
			{
				Console.Clear();
				Console.WriteLine("Please Choose another planet");
				s.Restart(character);
				character.callPlanets();
			}
			else if (leave == "2")
			{
				Console.Clear();
				p.sellingStonks();
			}
		}

		public void Earth()
		{
			Console.Clear();
			Inventory();
			Console.WriteLine("Do you have Enough?\n Press Enter to continue");
			Console.ReadLine();

			if (character.Storage.Coin < 5000 || character.Storage.Health < 35 || character.Storage.Fuel < 45)
			{
				//character.callPlanets();
				Console.WriteLine("Sorry but you dont have enough to go back to Earth. PLease turn back around and choose another planet\nPress Enter to continue.");
				Console.ReadLine();
				character.callPlanets();


			}
			else if (character.Storage.Coin >= 5000 && character.Storage.Health >= 35 && character.Storage.Fuel >= 45)
			{
				Console.WriteLine("Congrats You Have Enough To Go Back!\n Press Enter to continue.");
				Console.ReadLine();
				done.Exit();
			}
			

			//do
			//{

			//	Console.WriteLine("Sorry but you dont have enough to go back to Earth. PLease turn back around and choose another planet\nPress Enter to continue.");
			//	Console.ReadLine();
			//	Console.Clear();
			//	character.callPlanets();
			//}

			//while (character.Storage.Coin >= 5000 && character.Storage.Health >= 35 && character.Storage.Fuel >= 45);
			//{
			//	Console.WriteLine("Congrats You Have Enough To Go Back!\n Press Enter to continue.");
			//	Console.ReadLine();
			//	done.Exit();
			//}
		}
    }
}

