using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class Shop
    {

        




        Weapon[] weapArray = new Weapon[3];

        

        


        public void RandomWeapon()
        {
            Random RANDOM_NUMBER_GENERATOR = new Random();
            int[] intArray = new int[3];
            for (int i = 0; i < weapArray.Length;i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    bool Check = false;

                    while(Check ==false)
                    {
                        int Weapon = RANDOM_NUMBER_GENERATOR.Next(0, 4);

                        for (int k = 0;k<j;k++)
                        {
                            if(Weapon==intArray[k])
                            {
                                Check = false;
                                break;

                            }
                            else
                            {
                                Check = true;
                            }
                        }
                        if (Check == true)
                        {
                            intArray[j] = Weapon;
                        }
                    }

                    
                }

                for(int j=0;j<intArray.Length;j++)
                {
                    if(intArray[j] ==0)
                    {
                        weapArray[i] = Weapon("Weapon 1");
                    }
                }


            }



        }


        public bool CanBuy(int num)
        {

        }


        public void Buy(int num)
        {

        }

        public string DisplayWeapon(int num)
        {

        }

        


        

        
    }
}
