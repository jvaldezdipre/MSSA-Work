using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalSpaceXLibrary
{
   public class Character
   {
		public string name;
		
		public Character()
		{
			this.Storage = new Storage();
		}
		public Storage Storage { get; set; }
        public void Char()
        {
            
            Console.Write("Input your Characters Name: ");
            name = Console.ReadLine();
            Console.WriteLine("What is your gender\n1 - Male\n2 - Female");
			Console.Write(">> ");
            string gender = Console.ReadLine().ToString();

			while (gender != "1" && gender != "2")
            {
                Console.WriteLine("Please choose the correct gender to continue");
				Console.Write(">> ");
				gender = Console.ReadLine().ToString();
			}


            if (gender == "1")
            {
                Console.WriteLine($"Hello {name}! \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine($"!!!  Your wife has been kidnapped by ALIENS! You are not getting her \nback unless you bring back $5000 space coins back in 3 days . " +
                                   $"\n{name} you have to go to space and visit the planets and sell as \nmuch goods as you can to get that money to get your wife back!" +
                                  "\n Press Enter to continue. ");
                Console.ReadLine();
                Console.Clear();

            }
            else if (gender == "2")
            {
                Console.WriteLine($"Hello {name}! \nPress Enter to continue");
                Console.ReadLine();
                Console.WriteLine("!!!  YOUR FAMILY HAS BEEN ABDUCTED BY ALIEN. YOU NEED TO PAY RANSOM WORTH" +
                                 "\n$5000, YOU HAVE 72HRS TO TRAVEL SPACE TO MAKE RANSOM\n AMOUNT TO PAY \nBACK AND GET YOUR FAMILLY BACK. !!!" +
                                 $"\n{name} you have to go to space and visit the planets and sell as \nmuch goods as you can to get that money to get your FAMILY back!" +
                                 "\n Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine($"But be careful each planet you go to you loose 25% fuel and 15% health \neven if you do not buy anything from the planet. " +
                                  "\nThere will be 5 planets to travel to. 2 planets you actually buy \nitems to be able to sell," +
                                 "\nA selling planet where you can sell your items," +
                                 $"\nand a health and refuel planet to be able to heal up and refuel your \nship. Are you ready {name}!\n Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" You are starting off with 500 space coins as well as 5 pieces of copper.\nRemember you need 5000 space coins so be wise while traveling through the planets \n Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Choose a planet to start your journey. Remember choose wisely.");
            callPlanets();
            
        }


        public void callPlanets()
        {
			Console.WriteLine("1 - Pharvis sells Golds.\n2 - Crystal sells Diamonds.\n3 - Shell sells fuel\n4 - Bigagua restores health\n5 - Stonks buys your items.\n6 - Earth ");
			Console.Write(">> ");
			string location = Console.ReadLine().ToString();
			Planets p = new Planets();
            Console.Clear();
   //         while (location != "1" && location != "2" && location != "3" && location != "4" && location != "5" && location != "6")
   //         {
   //             Console.WriteLine("Please input the correct planet");
   //             Console.WriteLine("1- Pharvis sells Golds.\n2- Crystal sells Diamonds.\n3- Shell sells fuel\n4- Bigagua restores health\n5- Stonks buys your items.\n6 - Earth ");
			//	Console.Write(">> ");
			//	location = Console.ReadLine().ToString();
			//}

			switch (location)
			{
				case "1":
					p.Pharvis();

					break;

				case "2":
					p.Crystal();
					break;

				case "3":
					p.Shell();
					break;

				case "4":
					p.Bigagua();
					break;

				case "5":
					p.Stonks();
					break;

				case "6":
					p.Earth();
					break;

				default:
					Console.Clear();
					Console.WriteLine("Please input the correct planet");
					callPlanets();
					break;
					
			}

		}
   }
    
}
