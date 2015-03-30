using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM.Core
{
    interface IProvider
    {
        void ChangeFile(IFile toChange, IFile changed);

        void Delete(IFile file);

        IList<IFile> GetElements();

        void Store(IFile file);
    }
}
