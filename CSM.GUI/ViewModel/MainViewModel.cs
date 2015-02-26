using CAS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.GUI
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            xy = "Hallo, das Binding funktioniert";
        }

        public string xy
        {
            get;
            set;
        }
    }
}
