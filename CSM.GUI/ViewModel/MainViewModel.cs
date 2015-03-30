
using CSM.Core;
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
            Write = new ActionCommand(WriteXML) { Content ="Read" };
        }

        private void WriteXML()
        {
            throw new NotImplementedException();
        }

        public ActionCommand Write
        {
            get;
            set;
        }

        
    }
}
