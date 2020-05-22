using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyale
{
    abstract class Card
    {
        public string name;
        protected string rarity;
        protected string targets;
        protected double hitSpeed;
        protected int count;
        protected string range;
        protected string speed;
        public int CardLevel { get; protected set; }
        public int HitPoints { get; protected set; }
        public int Damage { get; protected set; }

        //All classes that implement Card must have all the abstract methods
        protected abstract void SetCardLevel();
        protected abstract void SetHitPoints();
        protected abstract void SetDamage();

        public void DoDamage(int dmg)
        {
            HitPoints -= dmg;
        }
        public bool IsAlive => HitPoints > 0;
    }
}
