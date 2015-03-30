using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.Core
{
    public class IItem : NotifyPropertyChanged
    {
        private object value;

        public object Value
        {
            get { return this.value; }
            set { this.value = value; OnPropertyChanged("Value"); }
        }

    }
}
