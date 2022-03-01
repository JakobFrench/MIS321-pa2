using System.IO;
using System;
using System.Collections.Generic;
using pa321_2.Moves;

namespace pa321_2.CHARACTERS
{
    public class JackSparrow : Character
    {
        public JackSparrow ()
        {
            Character JackSparrow = new Character(){name = "Davy Jones"};
            DistractOpponent distract = new DistractOpponent();
            distract.Attack(JackSparrow, JackSparrow);

            // characterName = "Jack Sparrow";
            // JackSparrow.SetAttack(new DistractOpponent());
        }
    }
}