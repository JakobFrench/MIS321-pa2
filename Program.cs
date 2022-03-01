using System.IO;
using System;
using System.Collections.Generic;
using pa321_2.Moves;

namespace pa321_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int power = rnd.Next(1, 100);
            int attStr = rnd.Next(1, power);
            int defStr = rnd.Next(1, power);
            Character Sparrow = new Character(){characterName = "CPU", maxPower = power, attackStr = attStr, defPower = power};
            System.Console.WriteLine("Welcome to the Pirates of Caribbean video game. To play, each player will select a character and fight their opponent. \nDifferent characters do different damages based on who they're fighting. Choose wisely or you might have to walk the plank!");
            int type = rnd.Next(4);
            if (type == 1)
            {
                Sparrow.SetAttack(new DistractOpponent());
            }
            else if (type == 2)
            {
                Sparrow.SetAttack(new CannonFire());
            }
            else if (type == 3)
            {
                Sparrow.SetAttack(new Sword());
            }
            Menu(Sparrow);
        }
        public static void Menu(Character Sparrow)
            {
                System.Console.WriteLine("Enter 1 to play against user\nEnter 2 to play against CPU");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    User(Sparrow);
                }
                else if (userInput == 2)
                {
                    CPU(Sparrow);
                }
                else if (userInput != 1 || userInput != 2)
                {
                    System.Console.WriteLine("Sorry, invalid selection");
                    Menu(Sparrow);
                }
            }

            public static void User(Character Sparrow)
            {
                Random rnd = new Random();
                int power = rnd.Next(99);
                int attStr = rnd.Next(1, power);
                int defStr = rnd.Next(1, power);
                int power2 = rnd.Next(99);
                int attStr2 = rnd.Next(1, power2);
                int defStr2 = rnd.Next(1, power2);
                Character playerOne = new Character(){name = "Will Turner", maxPower = power, attackStr = attStr, defPower = defStr};
                System.Console.WriteLine("Player One select which player you would like to play as...\n1. Jack Sparrow\t     Primary Attack: Distract Opponent\n2. Will Turner\t     Primary Attack: Sword\n3. Davy Jones\t     Primary Attack: Cannon Fire");
                int userSelection = int.Parse(Console.ReadLine());
                if (userSelection == 1)
                {
                    playerOne.name = "Jack Sparrow";
                    playerOne.SetAttack(new DistractOpponent());
                }
                else if (userSelection == 2)
                {
                    playerOne.name = "Will Turner";
                    playerOne.SetAttack(new Sword());                
                }
                else if (userSelection == 3)
                {
                    playerOne.name = "Davy Jones";
                    playerOne.SetAttack(new CannonFire());
                }
                else if (userSelection > 3 || userSelection < 1)
                {
                    System.Console.WriteLine("Sorry, invalide selection. Please choose again.\n");
                }
                Character playerTwo = new Character(){name = "Will Turner", maxPower = power2, attackStr = attStr2, defPower = defStr2};;
                System.Console.WriteLine("Player Two select which player you would like to play as...\n1. Jack Sparrow\t     Primary Attack: Distract Opponent\n2. Will Turner\t     Primary Attack: Sword\n3. Davy Jones\t     Primary Attack: Cannon Fire");
                int userInput = int.Parse(Console.ReadLine());
                System.Console.WriteLine(playerOne);
                if (userInput == 1)
                {
                    playerTwo.name = "Jack Sparrow";
                    playerTwo.SetAttack(new DistractOpponent());
                }
                else if (userInput == 2)
                {
                    playerTwo.name = "Will Turner";
                    playerTwo.SetAttack(new Sword());
                }
                else if (userInput == 3)
                {
                    playerTwo.name = "Davy Jones";
                    playerTwo.SetAttack(new CannonFire());
                }
                else if (userInput > 3 || userInput < 1)
                {
                    System.Console.WriteLine("Sorry, invalide selection. Please choose again.\n");
                }
                TwoPlayerFight(playerOne, playerTwo, Sparrow);
            }

            public static void CPU(Character Sparrow)
            {
                Random rnd = new Random();
                int maxPower = rnd.Next(101);
                int userAttack = rnd.Next(5, maxPower);
                int userDefense = rnd.Next(1, maxPower);
                System.Console.WriteLine("Enter the player you would like to play as. \n1. Jack Sparrow\t     Primary Attack: Distract Opponent\n2. Will Turner\t     Primary Attack: Sword\n3. Davy Jones\t     Primary Attack: Cannon Fire");
                int userSelection = int.Parse(Console.ReadLine());
                Character userCharacter = new Character() {maxPower = maxPower, attackStr = userAttack, defPower = userDefense};
                if (userSelection == 1)
                {
                    userCharacter.name = "Jack Sparrow";
                    userCharacter.SetAttack(new DistractOpponent());
                }
                else if (userSelection == 2)
                {
                    userCharacter.name = "Will Turner";
                    userCharacter.SetAttack(new Sword());                }
                else if (userSelection == 3)
                {
                    userCharacter.name = "Davy Jones";
                    userCharacter.SetAttack(new CannonFire());
                }
                else if (userSelection > 3 || userSelection < 1)
                {
                    System.Console.WriteLine("Sorry, invalide selection. Please choose again.\n");
                }
                FightCPU(userCharacter, Sparrow);
            }

            public static void TwoPlayerFight(Character userOne, Character userTwo, Character Sparrow)
            {
                Random rnd = new Random();
                int firstPerson = rnd.Next(1,3);
                if (firstPerson == 1)
                {
                    while (userOne.health > 0 && userTwo.health > 0)
                    {
                        Character playerOne = userOne;
                        Character playerTwo = userTwo;
                        userOne.attackType.Attack(playerOne, playerTwo);

                        userOne.attackStr = rnd.Next(5, userOne.maxPower);
                        userTwo.defPower = rnd.Next(1, userTwo.maxPower);
                        userTwo.attackStr = rnd.Next(5, userTwo.maxPower);
                        userOne.defPower = rnd.Next(1, userOne.maxPower);
                        playerTwo = userOne;
                        playerOne = userTwo;
                        playerOne.attackType.Attack(playerOne, playerTwo);
                    }
                    if (userOne.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userTwo.name + " has killed " + userOne.name + ". They win all the booty!");
                    }
                    if (userTwo.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userOne.name + " has killed " + userTwo.name + ". They win all the booty!");
                    }
                } else if (firstPerson == 2)
                {
                    while (userOne.health > 0 && userTwo.health > 0)
                    {
                        Character playerOne = userTwo;
                        Character playerTwo = userOne;
                        playerOne.attackType.Attack(playerOne, playerTwo);

                        userOne.attackStr = rnd.Next(5, userOne.maxPower);
                        userTwo.defPower = rnd.Next(1, userTwo.maxPower);
                        userTwo.attackStr = rnd.Next(5, userTwo.maxPower);
                        userOne.defPower = rnd.Next(1, userOne.maxPower);

                        playerTwo = userTwo;
                        playerOne = userOne;
                        playerOne.attackType.Attack(playerOne, playerTwo);
                    }
                    if (userOne.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userTwo.name + " has killed " + userOne.name + ". They win all the booty!\n");
                    }
                    if (userTwo.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userOne.name + " has killed " + userTwo.name + ". They win all the booty!\n");
                    }
                }
                userOne.health = 100;
                userTwo.health = 100;
                System.Console.WriteLine("1. Play Again\n2. Menu");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput ==1)
                {
                    TwoPlayerFight(userOne, userTwo, Sparrow);
                }
                else if (userInput == 2)
                {
                    Menu(Sparrow);
                }
                else if (userInput != 1 || userInput != 2)
                {
                    System.Console.WriteLine("Sorry. Invalid selection. Returning you to the Menu");
                    Menu(Sparrow);
                }
            }

            public static void FightCPU(Character userOne, Character Sparrow)
            {
                Random rnd = new Random();
                int firstPerson = rnd.Next(1,3);
                if (firstPerson == 1)
                {
                    while (userOne.health > 0 && Sparrow.health > 0)
                    {
                        Character playerOne = userOne;
                        Character playerTwo = Sparrow;
                        playerOne.attackType.Attack(playerOne, playerTwo);

                        userOne.attackStr = rnd.Next(5, userOne.maxPower);
                        Sparrow.defPower = rnd.Next(1, Sparrow.maxPower);
                        Sparrow.attackStr = rnd.Next(5, Sparrow.maxPower);
                        userOne.defPower = rnd.Next(1, userOne.maxPower);

                        playerTwo = userOne;
                        playerOne = Sparrow;
                        playerOne.attackType.Attack(playerOne, playerTwo);
                    }
                    if (userOne.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! The CPU has killed " + userOne.name + ". They win all the booty!");
                    }
                    if (Sparrow.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userOne.name + " has killed the CPU. You win all the booty!");
                    }
                } else if (firstPerson == 2)
                {
                    while (userOne.health > 0 && Sparrow.health > 0)
                    {
                        Character playerOne = Sparrow;
                        Character playerTwo = userOne;
                        playerOne.attackType.Attack(playerOne, playerTwo);

                        userOne.attackStr = rnd.Next(5, userOne.maxPower);
                        Sparrow.defPower = rnd.Next(1, Sparrow.maxPower);
                        Sparrow.attackStr = rnd.Next(5, Sparrow.maxPower);
                        userOne.defPower = rnd.Next(1, userOne.maxPower);

                        playerTwo = Sparrow;
                        playerOne = userOne;
                        playerOne.attackType.Attack(playerOne, playerTwo);
                    }
                    if (userOne.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! The CPU has killed " + userOne.name + ". They win all the booty!");
                    }
                    if (Sparrow.health <= 0)
                    {
                        System.Console.WriteLine("Shiver me timbers! " + userOne.name + " has killed the CPU. You win all the booty!");
                    }
                }
                userOne.health = 100;
                Sparrow.health = 100;
                System.Console.WriteLine("1. Play Again\n2. Menu");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput ==1)
                {
                    FightCPU(userOne, Sparrow);
                }
                else if (userInput == 2)
                {
                    Menu(Sparrow);
                }
                else if (userInput != 1 || userInput != 2)
                {
                    System.Console.WriteLine("Sorry. Invalid selection. Returning you to the Menu");
                    Menu(Sparrow);
                }
            }
    }
}
