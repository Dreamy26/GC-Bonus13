using System;

namespace BONUS_13
{
    internal class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string weaponType)
        {
            Name = "Warrior";
            Strength = 70;
            Intelligence = 60;
            WeaponType = weaponType;
            
        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Strength: {WeaponType}");
           
        }
    }
}