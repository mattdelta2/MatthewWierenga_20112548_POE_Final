using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Enemy
    {
        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        protected Enemy(int _X, int _Y, TileType _TYPEOFFILE, string _SYMBOL, int _DAMAGE, int _STARTINGHP, int _MAXHP)
        {
            DAMAGE = _DAMAGE;
            HP = _STARTINGHP;
            MAXHP = _MAXHP;

        }

        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }
        private TileType typeoftile;

        public TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }


        }

        private string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;


        }
        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }

        public object HP { get; private set; }
        public int MAXHP { get; private set; }
        public object DAMAGE { get; private set; }

        public override string ToString()
        {
            string Info = GetType().Name + "\n";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "] \n";
            Info += HP.ToString() + " HP \n";
            Info += "[" + DAMAGE.ToString() + "]";
            return Info;
        }

    }

     class Goblin : Enemy
    {

        public Goblin(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "G", int _DAMAGE = 1, int _STARTINGHP = 10, int _MAXHP = 10) :
        base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {


        }
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }
        private TileType typeoftile;

        public new TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }


        }

        private string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public void Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;

            VISION = new List<Tile>();


        }

        public void Goblins(int v1, int v2, TileType enemy, Tile[] tiles)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.enemy = enemy;
            this.tiles = tiles;
            
        }

        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }
        protected new Random RANDOM_NUMBER_GENERATOR = new Random();
        private int v1;
        private int v2;
        private TileType enemy;
        private Tile[] tiles;

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            int RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            while (VISION[RandomTileIndex].TYPEOFTILE.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            }

            if (VISION[RandomTileIndex].X > x) //moveRight
            {
                return MovementDirection.Right;


            }
            else if (VISION[RandomTileIndex].X < X) //MoveLeft
            {
                return MovementDirection.Left;
            }
            else if (VISION[RandomTileIndex].Y > y) //MoveDown
            {
                return MovementDirection.Down;
            }
            else if (VISION[RandomTileIndex].Y < Y) //MoveUp
            {
                return MovementDirection.Up;
            }

            return MovementDirection.NoMovement;

        }
    }



    class Mage : Enemy
    {

        public Mage(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "G", int _DAMAGE = 5, int _STARTINGHP = 5, int _MAXHP = 5) :
        base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {
        }
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }
        private TileType typeoftile;

        public TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }


        }

        private string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public void Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;


            VISION = new List<Tile>();


        }

        public void Mage(int v1, int v2, TileType enemy, Tile[] tiles)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.enemy = enemy;
            this.tiles = tiles;
        }

        private List<Tile> vision;
        private int v1;
        private int v2;
        private TileType enemy;
        private Tile[] tiles;

        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }

        public object HP { get; private set; }
        public object DAMAGE { get; private set; }

        public virtual bool CheckRange(Character Target)
        {
            int ReachableDistance = 2;
            if (DistanceTo(Target) <= ReachableDistance)
            {
                return true;
            }
            else return false;
        }

        private int DistanceTo(Character target)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string Info = GetType().Name + "\n";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "] \n";
            Info += HP.ToString() + " HP \n";
            Info += "[" + DAMAGE.ToString() + "]";
            return Info;
        }
    }

     class Leader : Enemy
    {
        public Leader(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "L", int _DAMAGE = 2, int _STARTINGHP = 20, int _MAXHP = 20) :
            base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {

        }
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }
        private TileType typeoftile;

        public new TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }


        }

        private string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public void Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;

            VISION = new List<Tile>();


        }





        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }
        protected new Random RANDOM_NUMBER_GENERATOR = new Random();
        private int v1;
        private int v2;
        private TileType enemy;
        private Tile[] tiles;

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            int RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            while (VISION[RandomTileIndex].TYPEOFTILE.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);

            }

            if (VISION[RandomTileIndex].X > x) //moveRight
            {
                return MovementDirection.Right;


            }
            else if (VISION[RandomTileIndex].X < X) //MoveLeft
            {
                return MovementDirection.Left;
            }
            else if (VISION[RandomTileIndex].Y > y) //MoveDown
            {
                return MovementDirection.Down;
            }
            else if (VISION[RandomTileIndex].Y < Y) //MoveUp
            {
                return MovementDirection.Up;
            }
            else if (VISION[RandomTileIndex] == null)
            {
                int moveRandom = RANDOM_NUMBER_GENERATOR.Next(0, 3);
                {
                    if (moveRandom == 0)
                    {
                        return MovementDirection.Up;
                    }
                    else
                        if (moveRandom == 1)
                    {
                        return MovementDirection.Down;
                    }
                    else
                    if (moveRandom == 2)
                    {
                        return MovementDirection.Left;
                    }
                    else
                        if (moveRandom == 3)
                    {
                        return MovementDirection.Right;
                    }
                }
            }

            return MovementDirection.NoMovement;


        }
        

    }
}

