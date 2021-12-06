using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Gold
    {
        int RANDOMNUMBERGENERATOR = new Random().Next(1, 6);

        public int GOLD { get; private set; }

        public Gold(int x, int y, TileType tileType, Tile[] tiles, char symbol = '$') 
        {

        }

        private int GoldAmount(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);

            
        }

        public void GetGold()
        {
            if(GetType() == Enemy(Mage))
            {
                GOLD = 3;
            }

            if(GetType() == Enemy(Goblin))
            {
                GOLD = 1;
            }

            if(GetType() == Enemy(Leader))
            {
                GOLD = 2;

            }
        }

        
    }
}
