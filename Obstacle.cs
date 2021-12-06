using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Obstacle
    {
        private int v;
        private int i;
        private object obstacle;

        public Obstacle(int v, int i, object obstacle)
        {
            this.v = v;
            this.i = i;
            this.obstacle = obstacle;
        }

        public Obstacle(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE)
        {

        }
    }
}
