using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class MapCreation
    {
        private Random RANDOMNUMBERGENERATOR;
        public Tile[,] Map;
        private Hero Character;
        public Hero CHARACTER
        {
            get { return Character; }
            set { Character = value; }
        }

        private int Enemies;
        private int GoldDrop;


        private List<Character> characters;
        public List<Character> CHARACTERS
        {
            get { return characters; }
            set { characters = value; }
        }

        private int mapwidth;
        public int MAPWIDTH

        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        private int mapheight;
        public int MAPHEIGHT

        {
            get { return mapheight; }
            set { mapheight = value; }
        }

        public MapCreation(int enemies, int _MAPWIDTH, int _MAPHEIGHT, int _GoldDrops)
        {
            CHARACTERS = new List<Character>();
            RANDOMNUMBERGENERATOR = new Random();
            Enemies = enemies;
            GoldDrop = _GoldDrops;
            this.MAPWIDTH = _MAPWIDTH;
            this.MAPHEIGHT = _MAPHEIGHT;
            CreateMap();
            RenderMap();
            SpawnGold();
        }


        private void initMap()
        {
            Map = new Tile[MAPWIDTH, MAPHEIGHT];
            for (int a = 0; a < MAPWIDTH; a++)
            {
                for (int s = 0; s < MAPHEIGHT; s++)
                {
                    Map[a, s] = new EmptyTile(a, s, TileType.Empty);
                }
            }
        }


        public void UpdateVision(Character CHARACTERS)
        {
            CHARACTER.VISION[0] = Map[CHARACTER.X, CHARACTER.Y + 1];
            CHARACTER.VISION[1] = Map[CHARACTER.X + 1, CHARACTER.Y];
            CHARACTER.VISION[2] = Map[CHARACTER.X, CHARACTER.Y - 1];
            CHARACTER.VISION[3] = Map[CHARACTER.X - 1, CHARACTER.Y];

        }

        private void CreateMap()
        {
            Map = new Tile[MAPWIDTH, MAPHEIGHT];
            initMap();
            drawBorders(MAPWIDTH, MAPHEIGHT);
            Hero Hero = new(0, 0, TileType.Hero, 50, 50, new Tile[])
            {


            };
            CHARACTERS.Add((Character)Hero);
            randomlyPlaceObject(Hero);
            for (int a = 0; a < Enemies; a++)
            {
                var gold = SpawnGold();
                randomlyPlaceObject(gold);
            }

            for (int k = 0; k < Enemies; k++)
            {
                var Goblin = CreateGoblin();
                CHARACTERS.Add((Character)Hero);
                randomlyPlaceObject(Goblin);

                var Mage = CreateMage();
                CHARACTERS.Add((Character)Hero);
                randomlyPlaceObject(Mage);


            }

            CHARACTERS.ForEach(UpdateVision);


        }

        private void randomlyPlaceObject(Hero hero)
        {
            throw new NotImplementedException();
        }

        private void randomlyPlaceObject(Mage mage)
        {
            throw new NotImplementedException();
        }

        private void randomlyPlaceObject(Goblin goblin)
        {
            throw new NotImplementedException();
        }

        private void randomlyPlaceObject(Gold gold)
        {
            throw new NotImplementedException();
        }

        private char[,] RenderMap()
        {
            char[,] res = new char[MAPWIDTH, MAPHEIGHT];
            for (int i = 0; i < MAPWIDTH; i++)
            {
                for (int j = 0; j < MAPHEIGHT; j++)
                {
                    res[i, j] = Map[i, j].SYMBOL;
                }
            }

            return res;
        }

        private void drawBorders(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Map[i, 0] = new Obstacle(0, i, TileType.Obstacle);
                Map[y - 1, i] = new Obstacle(0, i, TileType.Obstacle);
            }

            for (int i = 0; i < y; i++)
            {
                Map[0, i] = new Obstacle(0, i, TileType.Obstacle);
                Map[x - 1, i] = new Obstacle(0, i, TileType.Obstacle);
            }
        }

        private Goblin CreateGoblin()
        {

            return new Goblin(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }

        private Mage CreateMage()
        {

            return new Mage(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }


        private void randomlyPlaceObject(Tile tile)
        {

            var x = RANDOMNUMBERGENERATOR.Next(0 + 1, MAPWIDTH - 1);
            var y = RANDOMNUMBERGENERATOR.Next(0 + 1, MAPHEIGHT - 1);
            if (Map[x, y].TileType == TileType.Empty)
            {
                tile.X = x;
                tile.Y = y;
                Map[x, y] = tile;
            }
            else
            {
                randomlyPlaceObject(tile);
            }
        }

        private Gold SpawnGold()
        {
            return new Gold(0, 0, TileType.Enemy, new Tile[]
            {
                null,null,null,null
            });
        }
        public Items GetItemAtPosition()
        {

            return new Gold(0, 0, TileType.Enemy, new Tile[]);








        }
    }
}
