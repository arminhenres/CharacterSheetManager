using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSM.Core
{
    interface IFile : IXmlSerializable
    {
        string Name
        {
            get;
            set;
        }

    }
}
