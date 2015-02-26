using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class Spell
    {
        public string Level
        {
            get;
            set;
        }
        public int SpellsPerDay
        {
            get;
            set;
        }
        public int BonusSpells
        {
            get;
            set;
        }
    }
}
