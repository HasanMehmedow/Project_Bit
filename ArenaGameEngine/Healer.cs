using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaGameEngine.Healer;

namespace ArenaGameEngine
{
    internal class Healer
    {
        public class Healer : Hero
        {
            public int HealingPower { get; set; }

            public Healer(string name, int health, int level, int healingPower)
                : base(name, health, level)
            {
                HealingPower = healingPower;
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name} attacks");
            }

            public override void Defend()
            {
                Console.WriteLine($"{Name} defend yourself!");
            }

            public override void SpecialAbility()
            {
                Console.WriteLine($"{Name} restores his health!");
                Health += HealingPower;
            }

            public void HealAlly(Character ally)
            {
                Console.WriteLine($"{Name} heals {ally.Name} for {HealingPower} health points!");
                ally.Health += HealingPower;
            }
        }
    }
}
