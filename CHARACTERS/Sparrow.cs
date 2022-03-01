using System.IO;
using System;
using System.Collections.Generic;
using pa321_2.Moves;
namespace pa321_2.CHARACTERS
{
    public class Sparrow 
    {
        public Sparrow()
        {
            Random rnd = new Random();
            int power = rnd.Next(1, 100);
            int attStr = rnd.Next(1, power);
            int defStr = rnd.Next(1, power);
            Character Sparrow = new Character() {name = "Sparrow"};
            int type = rnd.Next(4);
            if (type == 1)
            {
                Sparrow.name = "Jack Sparrow";
                Sparrow.SetAttack(new DistractOpponent());
            }
            else if (type == 2)
            {
                Sparrow.name = "Will Turner";
                Sparrow.SetAttack(new CannonFire());
            }
            else if (type == 3)
            {
                Sparrow.name = "Davy Jones";
                Sparrow.SetAttack(new Sword());
            }
        }
    }
}