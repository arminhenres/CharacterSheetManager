using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class SavingThrow
    {
        public int BaseSave
        {
            get;
            set;
        }
        public int Modifier
        {
            get;
            set;
        }

        public int MagicModifier
        {
            get;
            set;
        }
        public int MiscModifier
        {
            get;
            set;
        }
        public int TempMod
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string RelevantAttribute
        {
            get;
            set;
        }

    }
}
