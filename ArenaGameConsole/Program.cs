using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Warrior warrior = new Warrior("Cris Roni");
            Healer healer = new Healer("Leo Messi");

            Arena arena = new Arena(knight, rogue, warrior, healer);
            arena.EventListener = new ConsoleGameEventListener();
            SecondArena arena2 = new SecondArena(warrior, healer);
            arena2.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner.Name}");
            Console.ReadLine();
            Console.WriteLine("Second battle begins.");
            Hero winner2 = arena2.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner2.Name}");
            Console.ReadLine();
        }
    }
}
