using System.IO;
using System;
using pa321_2.INTERFACES;
using pa321_2.Moves;

namespace pa321_2
{
    public class Character
    {
        public string characterName {get;set;}
        public int maxPower {get;set;}
        public double health = 100.0;
        public int attackStr {get;set;}
        public int defPower {get;set;}
        public string name {get;set;}

        public IAttack attackType {get;set;}

        
        public Character()
        {
            attackType = new DistractOpponent();
        }
        public void SetAttack (IAttack attack)
        {
            attackType = attack;
        }
        
    }
}