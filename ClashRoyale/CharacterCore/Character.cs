using System;

namespace CharacterCore
{
    public class Character
    {
        public enum TargetOptions
        {
            Air,
            Ground
        }
        public enum SpeedOptions
        {
            Slow,
            Medium,
            Fast
        }
        public enum RarityOptions
        {
            Common,
            Average,
            Rare,
            Epic
        }
        public enum RangeOptions
        {
            Melee,
            ShortRange,
            LongRange
        }
        public enum CharacterOptions
        {
            Wizard,
            Archer,
            Skeleton,
            Goblin
        }

        public Character(CharacterOptions characterOptions)
        {
            CharacterType = characterOptions;
            CardLevel = new Random().Next(1, 14);

            HitPoints = new Random().Next(342, 512);
            StartingHitPoints = HitPoints;

            switch (CharacterType)
            {
                case CharacterOptions.Wizard:
                    HitSpeed = 1.4;
                    AdditionalSpawn = 1;
                    Rarity = RarityOptions.Epic;
                    Target = TargetOptions.Air | TargetOptions.Ground;
                    Range = RangeOptions.LongRange;
                    Speed = SpeedOptions.Medium;
                    Damage = new Random().Next(24, 29);
                    break;
                case CharacterOptions.Archer:
                    HitSpeed = 1.2;
                    AdditionalSpawn = 2;
                    Rarity = RarityOptions.Average;
                    Target = TargetOptions.Air;
                    Range = RangeOptions.ShortRange;
                    Speed = SpeedOptions.Fast;
                    Damage = new Random().Next(19, 21);
                    break;
                case CharacterOptions.Skeleton:
                    HitSpeed = 1.1;
                    AdditionalSpawn = 1;
                    Rarity = RarityOptions.Common;
                    Target = TargetOptions.Ground;
                    Range = RangeOptions.Melee;
                    Speed = SpeedOptions.Slow;
                    Damage = new Random().Next(14, 17);
                    break;
                case CharacterOptions.Goblin:
                    HitSpeed = 1.0;
                    AdditionalSpawn = 3;
                    Rarity = RarityOptions.Common;
                    Target = TargetOptions.Ground;
                    Range = RangeOptions.Melee;
                    Speed = SpeedOptions.Slow;
                    Damage = new Random().Next(16, 19);
                    break;
                default:
                    HitSpeed = 1.0;
                    AdditionalSpawn = 1;
                    Rarity = RarityOptions.Common;
                    Target = TargetOptions.Ground;
                    Range = RangeOptions.Melee;
                    Speed = SpeedOptions.Slow;
                    Damage = new Random().Next(12, 15);
                    break;
            }
        }

        public CharacterOptions CharacterType { get; set; }
        public RarityOptions Rarity { get; private set; }
        public TargetOptions Target { get; private set; }
        public double HitSpeed { get; private set; }
        public static int AdditionalSpawn { get; private set; }
        public RangeOptions Range { get; set; }
        public SpeedOptions Speed { get; set; }
        public int CardLevel { get; private set; }
        public int HitPoints { get; private set; }
        public int StartingHitPoints { get; private set; }
        public int Damage { get; private set; }
        public bool IsAlive => HitPoints > 0;
        public int DamageTaken => StartingHitPoints - Damage;

        public void DoDamage(int dmg)
        {
            this.HitPoints -= dmg;
        }

        public override string ToString()
        {
            return ($"Character Name: {CharacterType}\nRarity: {Rarity}\nTargets: {Target}\nHit Speed {HitSpeed}\nRange: {Range}\nSpeed: {Speed}\nCard Level: {CardLevel}\nHit Points: {HitPoints}\nDamage per hit: {Damage}");
        }
    }
}
