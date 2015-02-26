using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class AcItem : Item
    {
       public int Bonus
        {
            get;
            set;    
        }
        public string Type
        {
            get;
            set;
        }
        public int CheckPenalty
        {
            get;
            set;
        }
        public int SpellFailure
        {
            get;
            set;
        }
        public string ItemProperties
        {
            get;
            set;
        }
    }
}

