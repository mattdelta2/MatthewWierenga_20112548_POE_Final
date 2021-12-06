using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Character
    {
        protected int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        protected int maxhp;
        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        protected int damage;
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }

        private List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }


        }

        private MovementDirtection movement;
        public MovementDirtection MOVEMENT
        {
            get { return movement; }
            set { movement = value; }
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

        protected int gold;
        public int GOLD
        {
            get { return gold; }
            set { gold = value; }
        }


        public static object Gold { get; internal set; }

        public void Character(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE, int _HP, int _MAXHP, int _DAMAGE)
        {
            X = _X;
            Y = _Y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;
            HP = _HP;
            MAXHP = _MAXHP;
            DAMAGE = _DAMAGE;
            VISION = new List<Tile>();
        }

        public virtual void Attack(Character Target)
        {
            Target.HP -= DAMAGE;
        }

        public bool IsDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else return false;
        }

        public virtual bool CheckRange(Character Target)
        {
            int ReachableDistance = 1;
            if (DistanceTo(Target) <= ReachableDistance)
            {
                return true;
            }
            else return false;
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }

        public void Move(MovementDirection CharacterMove)
        {
            switch (CharacterMove)
            {
                case MovementDirection.Up:
                    Y--;
                    break;
                case MovementDirection.Down:
                    Y++;
                    break;
                case MovementDirection.Left:
                    X--;
                    break;
                case MovementDirection.Right:
                    X++;
                    break;

            }

        }

        public abstract MovementDirection ReturnMove(MovementDirtection CharacterMove = 0);
        public abstract override string ToString();


        public static void Pickup(Item i)
        {

        }

        internal void Attack()
        {
            throw new NotImplementedException();
        }

        internal void Move()
        {
            throw new NotImplementedException();
        }

        public void Loot()
        {
            bool IsDead = false;

            if(Character(HP)>=0)
            {
                IsDead = true;
                {
                    if(Character(GoldAmmount)>0)
                    {
                        Character(GoldAmount) = +Character(GoldAmount);
                    }
                }
            }
        }
    }
}

