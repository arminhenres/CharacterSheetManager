using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class Weapon : Item
    {
        public int AttackBonus
        {
            get;
            set;
        }

        public string Critical
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public int Range
        {
            get;
            set;
        }

        public string Damage
        {
            get;
            set;
        }



        public string GetDamage(int count, Dice type, int bonus)
        {
            string damage = count.ToString() + type.ToString() + "+" + bonus;
            return damage;
        }
    }
}
