using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.OperationBed.DataTypes
{
    public class ClassAttribute
    {
        public string Name
        {
            get;
            set;
        }

        public string Short
        {
            get;
            set;
        }


        public int Score
        {
            get;
            set;
        }

        public int Modifier
        {
            get
            {
                int mod = (Score / 2) - 5;
                return mod;
            }
        }
    }
}
