using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    class HeroBase
    {
        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            if (CharacterMove is null)
            {
                throw new ArgumentNullException(nameof(CharacterMove));
            }

            if (CheckForValidMove(CharacterMove))
            {
                return CharacterMove;

            }
            else return MovementDirection.NoMovement;

        }
    }
}
