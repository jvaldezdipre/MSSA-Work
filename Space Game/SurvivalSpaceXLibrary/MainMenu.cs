using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalSpaceXLibrary
{
    public class MainMenu
    {
		Character character = new Character();
		public void Menu()
		{

			Character c = new Character();
			Console.WriteLine("SURVIVAL SPACE X!\nPress\n1 - Start\n2 - Exit if you dont have what it takes to survive!");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();
			Console.Clear();

				while (choose != "1" && choose != "2")
				{
					Console.WriteLine("Wrong Input please Write the correct choices");
				Console.Write(">> ");
				choose = Console.ReadLine().ToString();
				}


				if (choose =="1")
				{
					c.Char();
				}
				else if (choose == "2")
				{
					Environment.Exit(0);
				}
		}

		public void Restart()
        {
            Console.WriteLine("1 - Try Again?\n2 - Exit");
			Console.Write(">> ");
			string choose = Console.ReadLine().ToString();

			while (choose != "1" && choose != "2")
			{
				Console.WriteLine("Wrong Input please Write the correct choices");
				Console.Write(">> ");
				choose = Console.ReadLine().ToString();
			}

			switch (choose)
			{
				case "1":
					character.Char();
					break;
				case "2":
					Exit();
					break;
			}
				
			
        }


        public void Exit()
        {
			Console.Clear();
			Console.WriteLine("THANKS FOR PLAYING!");
			Console.ReadLine();
			Environment.Exit(0);
		}
    }
}
