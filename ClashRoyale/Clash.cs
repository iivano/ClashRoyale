using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCore;

namespace ClashRoyale
{
    class Clash
    {
        public static void Battle(Character card1, Character card2)
        {
            int roundCount = 1;

            Random random = new Random();
            int firstHit = random.Next(1, 3);

            while(card1.IsAlive && card2.IsAlive)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Round {roundCount}");
                Console.WriteLine("-------");

                if(firstHit == 1)
                {
                    card2.DoDamage(card1.Damage);
                    Console.WriteLine($"{card2.CharacterType} takes a hit with {card1.Damage} points damage.");

                    card1.DoDamage(card2.Damage);
                    Console.WriteLine($"{card1.CharacterType} takes a hit with {card2.Damage} points damage");
                }
                else
                {
                    card1.DoDamage(card2.Damage);
                    Console.WriteLine($"{card1.CharacterType} takes a hit with {card2.Damage} points damage");

                    card2.DoDamage(card1.Damage);
                    Console.WriteLine($"{card2.CharacterType} takes a hit with {card1.Damage} points damage");
                }
                roundCount++;
                firstHit = random.Next(1, 3);
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER:");
            Console.WriteLine($"{card1.CharacterType} HP: {card1.HitPoints}\n{card2.CharacterType} HP: {card2.HitPoints}");
        }
    }
}
