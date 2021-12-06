using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class MovementDirection
    {
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Barrier,
            Empty
        }

        public enum MovementDirections
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right
        }
    }
}

