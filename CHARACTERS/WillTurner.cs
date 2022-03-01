using System.IO;
using System;
using System.Collections.Generic;
using pa321_2.Moves;

namespace pa321_2.CHARACTERS
{
    public class WillTurner : Character
    {
        public WillTurner ()
        {
            Character WillTurner = new Character(){characterName = "Will Turner"};
            Sword sword = new Sword();
            sword.Attack(WillTurner, WillTurner);

            // characterName = "Will Turner";
            // WillTurner.SetAttack(new Sword());
        }
    }
}