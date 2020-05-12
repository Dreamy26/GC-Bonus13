using System;

namespace BONUS_13
{
    internal class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard(string name)
 
        {
            Name = name;
            SpellNumber = 80;
            Strength = 70;
            Intelligence = 120;
            MagicalEnergy = 80;
        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}"); 
            Console.WriteLine($"Strength: {MagicalEnergy}");
            Console.WriteLine($"Intelligence: {SpellNumber}");
        }
    }
}