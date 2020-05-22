using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyale
{
    class Archers : Card
    {
        public Archers()
        {
            name = "Archers";
            rarity = "Common";
            targets = "Air & Ground";
            hitSpeed = 1.2;
            count = 2;
            range = "Melee";
            speed = "Medium";
            SetCardLevel();
            SetHitPoints();
            SetDamage();
        }

        Random random = new Random();

        protected override void SetCardLevel()
        {
            CardLevel = random.Next(1, 14);
        }
        protected override void SetHitPoints()
        {
            HitPoints = random.Next(110, 122);
        }
        protected override void SetDamage()
        {
            Damage = random.Next(9, 14);
        }

        public override string ToString()
        {
            return ($"{name}:\nRarity: {rarity}\nTargets: {targets}\nHit Speed: {hitSpeed}\nCount: {count}\nRange: {range}\nCard Level: {CardLevel}\nHit Points: {HitPoints}\nDamage: {Damage}");
        }
    }
}
