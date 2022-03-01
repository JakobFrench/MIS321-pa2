using pa321_2.INTERFACES;
using System.IO;
using System;
namespace pa321_2.Moves
{
    public class CannonFire : IAttack
    {
        public double Attack(Character playerOne, Character playerTwo)
        {
            if (playerTwo.name == "Jack Sparrow")
            {
                double damageDone = ((playerOne.attackStr - playerTwo.defPower) * 1.20);
                if (damageDone < 1)
                {
                    damageDone = 1;
                }
                playerTwo.health -= damageDone;
                System.Console.WriteLine(playerOne.name + " used Cannon Fire dealing " + playerOne.attackStr + ", but " + playerTwo.name + " defended with " + playerTwo.defPower + " defense. Resulting in " + damageDone + " damage.\n    Player One Health: " + playerOne.health + "\n    Player Two Health: " + playerTwo.health);
                return damageDone;
            } 
            else 
            {
                double damageDone = (playerOne.attackStr - playerTwo.defPower);
                if (damageDone < 1)
                {
                    damageDone = 1;
                }
                playerTwo.health -= damageDone;
                System.Console.WriteLine(playerOne.name + " used Cannon Fire dealing " + playerOne.attackStr + ", but " + playerTwo.name + " defended with " + playerTwo.defPower + " defense. Resulting in " + damageDone + " damage.\n    Player One Health: " + playerOne.health + "\n    Player Two Health: " + playerTwo.health);
                return damageDone;
            }
        }
    }
}