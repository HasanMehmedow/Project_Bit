using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    internal class Warrior
    {
        public class Warrior : Hero
        {
            public int Strength { get; set; }

            public Warrior(string name, int health, int level, int strength)
                : base(name, health, level)
            {
                Strength = strength;
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name} swings a mighty sword!");
            }

            public override void Defend()
            {
                Console.WriteLine($"{Name} blocks with a shield!");
            }

            public override void SpecialAbility()
            {
                Console.WriteLine($"{Name} uses Berserk Rage, increasing strength!");
                Strength += 10;
            }

            public void Charge()
            {
                Console.WriteLine($"{Name} charges towards the enemy!");
            }
        }
    }
}