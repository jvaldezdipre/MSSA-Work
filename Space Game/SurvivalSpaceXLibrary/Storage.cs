using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalSpaceXLibrary
{
    public class Storage
    {

        public Storage()
        {
            
            this.Coin = 500;
            this.Health = 100;
            this.Fuel = 100;
            this.Gold = 0;
            this.Silver = 0;
            this.Copper = 5;
            this.Diamond = 0;
            this.Ruby = 0;
            this.Saphire = 0;
        }

        public double Health
		{
			get; set;
		}


		public double Fuel
        {
            get; set;
        }
		public double Coin
        {
            get; set;
        }
		public double Gold
        {
            get; set;
        }
		public double Silver
        {
            get; set;
        }
		public double Copper
        {
            get; set;
        }
		public double Diamond
        {
            get; set;
        }
		public double Ruby
        {
            get; set;
        }
		public double Saphire
        {
            get; set;
        }

	}
}
