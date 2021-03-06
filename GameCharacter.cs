﻿using System;

namespace BONUS_13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter()
        {
            Name = "Default Character";
            Strength = 50;
            Intelligence = 95;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
}

    }
}