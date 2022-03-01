using System.IO;
using System;
using System.Collections.Generic;
using pa321_2.Moves;

namespace pa321_2.CHARACTERS
{
    public class DavyJones : Character
    {
        public DavyJones ()
        {
            Character DavyJones = new Character(){characterName = "Davy Jones"};
            CannonFire cannon = new CannonFire();
            cannon.Attack(DavyJones, DavyJones);
            // DavyJones.SetAttack(new CannonFire());
            //Character DavyJones = new Character() {characterName = "Davy Jones"};
        }
    }
}