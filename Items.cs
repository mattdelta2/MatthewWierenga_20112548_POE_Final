using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Items
    {
    }







    internal class GOLD : Items
    {
        int RANDOMNUMBERGENERATOR = new Random().Next(1, 6);


        public GOLD(int x, int y, TileType tileType, Tile[] tiles, string _symbol = "$") 
        {

        }

        public int X { get; private set; }
        public int Y { get; private set; }

        private int GoldAmount(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }


    }


    abstract class items : Tile
    {
        private char symbol1;

        public items(int _x, int _y, TileType _TYPEOFTILE, string _SYMBOL = "#") : base(_x, _y, _SYMBOL, _TYPEOFTILE)
        {

        }



      

        public override string ToString()
        {
            return $"Player Item:\r\nDamage:\r\n[{X},{Y}]";
        }
    }
}
