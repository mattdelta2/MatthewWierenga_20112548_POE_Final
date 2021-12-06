using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class TileType
    {
        public static TileType Empty { get; internal set; }
        public static TileType Enemy { get; internal set; }
        public static TileType Weapon { get; internal set; }
        public static object Hero { get; internal set; }
        public static object Obstacle { get; internal set; }
    }
}
