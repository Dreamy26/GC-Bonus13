using System;

namespace BONUS_13
{
    internal class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
            

        public MagicUsingCharacter()

        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"MagicEnergy: {MagicalEnergy}");

        }
    }
}