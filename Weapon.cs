using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Weapon
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;
        private string symbol;

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

        public List<Tile> VISION { get; private set; }

        public Weapon(string weaponType)
        {/*
            this.damage = damage;
            this.range = range;
            this.durability = durability;
            this.cost = cost;
            this.weaponType = weaponType;
        */
            if(weaponType =="Dagger" || weaponType=="Longsword")
            {
                MeleeWeapon(weaponType);
            }
            else
                if(weaponType == "LongBow"||weaponType =="Rifle")
            {
                RangeWeapon(weaponType);
            }

            else
            if(weaponType == null)
            {
                MeleeWeapon(weaponType);
            }

            
        }
        
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }


        public int RANGE
        {
            get { return range; }
            set { range = value; }
        }


        public int DURABILITY
        {
            get { return durability; }
            set { durability = value; }

        }


        public int COST
        {
            get { return cost; }
            set { cost = value; }
        }



        public string WEAPONTYPE
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }



        enum Types
        {
            Dagger,
            Longsword,
            Rifle,
            Longbow,
            BareHands


        }







        public void MeleeWeapon(string weaponType)
        {


            damage = 0;
            durability = 0;
            cost = 0;
            range = 1;
            string symbol = "";
            if (weaponType == "Dagger")
            {
                damage = 3;
                durability = 10;
                cost = 3;
                symbol = "D";
            }

            if (weaponType == "Longsword")
            {
                damage = 4;
                durability = 6;
                cost = 5;
                symbol = "LS";
            }

            if(weaponType =="" || weaponType ==null)
            {
                damage = 2;
                range = 1;
            }

            
            

        }







       
        
            public void RangeWeapon( string weaponType)
            {
                if (weaponType == "Longbow")
                {
                    damage = 4;
                    range = 2;
                    durability = 4;
                    cost = 6;
                    symbol = "LB";

                }

                if (weaponType == "Rifle")
                {
                    damage = 4;
                    range = 2;
                    durability = 4;
                    cost = 7;
                    symbol = "R";
                }


            }

            public string toString()
            {
            return "Current Weapon:" + weaponType + "\nWeapon Range: " + range.ToString() + "\nWeapon Damage: " + damage.ToString() +
                    "\nDurability: " + durability.ToString() + "\n";

            }

        public void Tile(int _x, int _y, string _SYMBOL, TileType _TYPEOFTILE)
        {
            X = _x;
            Y = _y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;


            VISION = new List<Tile>();


        }


    }
    
    
    }




