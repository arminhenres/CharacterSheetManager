using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class ClassSkill
    {
        public string Name
        {
            get;
            set;
        }
        public bool IsClassSkill
        {
            get;
            set;
        }
        public string RelevantAttribute
        {
            get;
            set;
        }
        public int AbilityMod
        {
            get;
            set;
        }
        public int Ranks
        {
            get;
            set;
        }
        public int MiscMod
        {
            get;
            set;
        }
        public string Total
        {
            get
            {
                int total = AbilityMod + Ranks + MiscMod;
                string totals;
                if(total>=0)
                {
                    totals = "+" + total.ToString();
                }
                else
                {
                    totals = total.ToString();
                }
                return totals;
            }
        }
    }
}
