using System;

namespace BONUS_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var gameCharacter = new GameCharacter[5];
            gameCharacter[0] = new Warrior("sword");
            gameCharacter[1] = new Warrior("star");
            gameCharacter[2] = new Wizard("axe");
            gameCharacter[3] = new Wizard("cake");
            gameCharacter[4] = new Wizard("Butterfly");

            foreach (var character in gameCharacter)
            {
                character.Play();
                Console.WriteLine();
            }
           
            

        }
    }
}
