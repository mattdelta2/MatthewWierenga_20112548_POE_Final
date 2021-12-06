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







    internal class Gold : Items
    {
        int RANDOMNUMBERGENERATOR = new Random().Next(1, 6);


        public Gold(int x, int y, TileType tileType, Tile[] tiles, string _symbol = "$") : base(x, y, _symbol, tileType)
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

        public items(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE) : base(_x, _y, _SYMBOL, _TYPEOFTILE)
        {
        }

        protected items(int x, int y, char symbol1, TileType tileType)
        {
            this.x = x;
            this.y = y;
            this.symbol1 = symbol1;
            TileType = tileType;
        }

        public override string ToString()
        {
            return $"Player Item:\r\nDamage:\r\n[{X},{Y}]";
        }
    }
}
